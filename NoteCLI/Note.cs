using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteCLI
{
    internal class Note
    {
        private static int _nextId = 1;
        private int _id;
        private string _title;
        private string _content;

        public Note(string title, string content)
        {
            this.Id = _nextId;
            this._title = title;
            this._content = content;
            _nextId++;
        }

        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }
        public string Content
        {
            get
            {
                return this._content;
            }
            set
            {
                this._content = value;
            }
        }

        public int Id
        {
            get
            {
                return this._id;
            }
            private set
            {
                this._id = value;
            }
        }
    }
}
