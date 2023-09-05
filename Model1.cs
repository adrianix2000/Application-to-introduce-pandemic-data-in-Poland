namespace Covid_Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;
    using Covid_Data.DataLayer.DataModels;
    using System.Threading.Tasks;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<DataOfPolands> DataOfPolands { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public async Task<List<OneDayOfPoland>> GetListOfDays()
        {
            List<OneDayOfPoland> result = new List<OneDayOfPoland>();

            await Task.Run(() =>
            {
                result = DataOfPolands.Select(d => new OneDayOfPoland
                {
                    Date = d.Date,
                    NewConfirmed = d.NewConfirmed,
                    NewDeaths = d.NewDeaths,
                    TotalConfirmed = d.TotalConfirmed,
                    TotalDeaths = d.TotalDeaths,

                }).ToList();

                for (int i = 0; i < result.Count(); i++)
                {
                    result[i].Id = i + 1;
                }
            });

            return result;
        }
    }
}
