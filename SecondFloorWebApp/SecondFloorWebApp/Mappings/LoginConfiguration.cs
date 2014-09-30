using SecondFloorWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SecondFloorWebApp.Mappings
{
    public class LoginConfiguration : EntityTypeConfiguration<Login>
    {
        public LoginConfiguration()
        {
            ToTable("TAB_LOGIN");
            HasKey(l => l.Id);
            Property(l => l.Id).HasColumnName("ID_LOGIN");
            Property(l => l.Email);
            Property(l => l.Senha);
            Property(l => l.Token);

            HasRequired(l => l.Anunciante).WithRequiredDependent(a => a.Login);
        }
    }
}