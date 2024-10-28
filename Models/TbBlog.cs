using System;
using System.Collections.Generic;

namespace Harmic.Models;

public partial class TbBlog
{
    public int BlogId { get; set; }

    public string Title { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public int CategoryId { get; set; }

    public string Description { get; set; } = null!;

    public string Detail { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string SeoTitle { get; set; } = null!;

    public string SeoDescription { get; set; } = null!;

    public string SeoKeywords { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public int AccountId { get; set; }

    public bool IsActive { get; set; }

    public virtual TbAccount Account { get; set; } = null!;

    public virtual TbCategory Category { get; set; } = null!;

    public virtual ICollection<TbBlogComment> TbBlogComments { get; set; } = new List<TbBlogComment>();
}
