﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRM.Models
{
    public class Employee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Employee Code")]
        [StringLength(10)]
        public string EmployeeCode { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Nick Name")]
        public string NickName { get; set; }



       
        public int MobieNumber { get; set; }
        

      



     

        [Display(Name = "Email")]
        public string Email { get; set; }


     


        [Display(Name = "Father Name")]
        public string FatherName { get; set; }
        [Display(Name = "Mother Name")]
        public string MotherName { get; set; }

        public int DesignationId { get; set; }

        [Foreignkey("DesignationId")]

        public virtual Designation Designation { get; set; }


        public string BloodGroup { get; set; }




     



        [Display(Name = "Dept Name")]
        public int  DeptId { get; set; }
        [Foreignkey("DeptId")]
        public virtual Dept Dept { get; set; }
        
   


        [Display(Name ="Address")]
        public string Address { get; set; }


        [Display(Name ="Upload File")]
        public string EmployeePhotoPath { get; set; }


        [NotMapped]
        public HttpPostedFileBase EmployeePhoto { get; set; }

        

        

       

        
    }
}