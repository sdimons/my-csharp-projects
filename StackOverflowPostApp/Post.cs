using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPostApp
{
    public class Post
    {
        private int _votes = 0;
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int Votes
        {
            get
            {
                return _votes;
            }
        }

        public void Up_Vote()
        {
            _votes++;
        }
        public void Down_Vote()
        {
            _votes--;
            if (_votes < 0)
                _votes = 0;
        }
    }
}
