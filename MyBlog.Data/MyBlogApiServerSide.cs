using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Interfaces;
using MyBlog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType; // included in template, causes error, don't think it's necessary

namespace MyBlog.Data
{
    public class MyBlogApiServerSide : IMyBlogApi
    {
        IDbContextFactory<MyBlogDbContext> factory;
        public MyBlogApiServerSide(IDbContextFactory<MyBlogDbContext> factory) 
        {
            this.factory = factory;
        }
        public async Task<BlogPost> GetBlogPostAsync(int id)
        {
            using var context = factory.CreateDbContext();
            return await context.BlogPosts.Include(p => p.Category).Include(p => p.Tags).FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task<int> GetBlogPostCountAsync()
        {
            using var context = factory.CreateDbContext();
            return await context.BlogPosts.CountAsync();
        }
        public async Task<List<BlogPost>> GetBlogPostsAsync(int
        numberofposts, int startindex)
        {
            using var context = factory.CreateDbContext();
            return await context.BlogPosts.OrderByDescending(p => p.PublishDate).Skip(startindex).Take(numberofposts).ToListAsync();
        }
        public async Task<List<Category>> GetCategoriesAsync()
        {
            using var context = factory.CreateDbContext();
            return await context.Categories.ToListAsync();
        }
        public async Task<Category> GetCategoryAsync(int id)
        {
            using var context = factory.CreateDbContext();
            return await context.Categories.Include(p => p.BlogPosts).FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<Tag> GetTagAsync(int id)
        {
            using var context = factory.CreateDbContext();
            return await context.Tags.Include(p => p.BlogPosts).FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<List<Tag>> GetTagsAsync()
        {
            using var context = factory.CreateDbContext();
            return await context.Tags.ToListAsync();
        }
        private async Task DeleteItem(IMyBlogItem item)
        {
            using var context = factory.CreateDbContext();
            context.Remove(item);
            await context.SaveChangesAsync();
        }
        public async Task DeleteBlogPostAsync(BlogPost item)
        {
            await DeleteItem(item);
        }
        public async Task DeleteCategoryAsync(Category item)
        {
            await DeleteItem(item);
        }
        public async Task DeleteTagAsync(Tag item)
        {
            await DeleteItem(item);
        }
        private async Task<IMyBlogItem> SaveItem(IMyBlogItem item)
        {
            using var context = factory.CreateDbContext();
            if (item.Id == 0)
            {
                if (item is BlogPost)
                {
                    var post = item as BlogPost;
                    post.Category = await context.Categories.FirstOrDefaultAsync(c => c.Id == post.Category.Id);
                    context.Add(item);
                }
                else
                {
                    context.Add(item);
                }
            }
            else
            {
                if (item is BlogPost)
                {
                    var post = item as BlogPost;
                    var currentpost = await context.BlogPosts.Include(p => p.Category).Include(p => p.Tags).FirstOrDefaultAsync(p => p.Id == post.Id);
                    currentpost.PublishDate = post.PublishDate;
                    currentpost.Title = post.Title;
                    currentpost.Text = post.Text;
                    var ids = post.Tags.Select(t => t.Id);
                    currentpost.Tags = context.Tags.Where(t => ids.Contains(t.Id)).ToList();
                    currentpost.Category = await context.Categories.FirstOrDefaultAsync(c => c.Id == post.Category.Id);
                    await context.SaveChangesAsync();
                }
                else
                {
                    context.Entry(item).State = EntityState.Modified;
                }
            }
            await context.SaveChangesAsync();
            return item;
        }
        public async Task<BlogPost> SaveBlogPostAsync(BlogPost item)
        {
        return (await SaveItem(item)) as BlogPost;
        }
        public async Task<Category> SaveCategoryAsync(Category item)
        {
            return (await SaveItem(item)) as Category;
        }
        public async Task<Tag> SaveTagAsync(Tag item)
        {
            return (await SaveItem(item)) as Tag;
        }
        public void GetTableNames()
        {
            using var context = factory.CreateDbContext();
            var tableNames = context.Model.GetEntityTypes().Select(t => t.GetTableName()).Distinct().ToList();
            Console.WriteLine(tableNames);
        }

    }
}
