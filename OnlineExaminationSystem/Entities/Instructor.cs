﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace OnlineExaminationSystem.Entities;

// 2. inherit
public partial class Instructor : Person
{
    /// 3. COMMENT
    //public int Id { get; set; }

    public int DeptId { get; set; }

    public double? Salary { get; set; }

    public virtual Department Dept { get; set; }

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    /// 4. COMMENT

    //public virtual Person IdNavigation { get; set; }

    public virtual ICollection<Course> CIds { get; set; } = new List<Course>();
}