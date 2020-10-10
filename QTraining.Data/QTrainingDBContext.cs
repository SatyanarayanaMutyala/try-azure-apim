using Microsoft.EntityFrameworkCore;
using QTraining.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QTraining.Data
{
    public class QTrainingDBContext: DbContext
    {
        public QTrainingDBContext(DbContextOptions<QTrainingDBContext> options)
            :base(options)
        {

        }

        public DbSet<Session> Sessions { get; set; }
    }
}
