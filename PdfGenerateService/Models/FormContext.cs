using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PdfGenerateService.Models
{
    public class FormContext : DbContext
    {
        public FormContext(DbContextOptions<FormContext> options) : base(options)
        {

        }

        public DbSet<FormDataItems> FormDataItems { get; set; }
    }
}
