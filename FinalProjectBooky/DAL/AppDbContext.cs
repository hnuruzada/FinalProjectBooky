﻿using FinalProjectBooky.Migrations;
using FinalProjectBooky.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectBooky.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<AuthorBook> AuthorBooks { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Language> Languages { get; set; }
        
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<BookTag> BookTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<FooterSocialMedia> FooterSocialMedias { get; set;}
        public DbSet<IconContainer> IconContainers{ get; set; }
        
        public DbSet<SocialMedia> SocialMedias { get; set; }

    }
}