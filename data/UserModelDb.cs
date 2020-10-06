using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace TestApi.data
{
    public class UserModelDb
    {
        public int Id { get; set; }
        /// <summary>
        /// Name of User
        /// </summary>
        [StringLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// Age of User
        /// </summary>
        public int Age { get; set; }

    }
}
