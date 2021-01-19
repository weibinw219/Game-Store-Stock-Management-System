using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Team_WASD___Game_Store_Stock_Management_System
{
    /*
     * Author: Wei Bin Wang
     */
    /// <summary>
    /// This class is partial class of the object Game
    /// Since we need to specify the primary key but we cant change the file inside DBMoel
    /// </summary>
    [MetadataType(typeof(ColumnProperty))]
    public partial class Game
    {
    }

    /// <summary>
    /// The class that specify the column property to be added
    /// </summary>
    public class ColumnProperty
    {
        // Specify the id as the primary key
        [Key]
        public int Id { get; set; }


    }
}