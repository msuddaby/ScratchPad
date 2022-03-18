using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad3
{
    public class PostDTO
    {
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public UsernameDTO UsernameDisplay { get; set; }
        public int CommentCount { get; set; }
    }
}
