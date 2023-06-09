﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class ProductReview
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool IsLike { get; set; }

        //overriding ToString Method for DisplayMethod
        public override string ToString()
        {
            return $"ProductId = {ProductId}, UserId = {UserId}, Rating = {Rating}, Review = {Review}, IsLike = {IsLike}";
        }
    }
}
