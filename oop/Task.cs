using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    class Task
    {

        private int TaskId;
        private string Title;
        private string Description;
        private bool Enabled;

        // constructor
        public Task(int id, string title, string desc)
        {
            TaskId = id;
            Title = title;
            Description = desc;
            Enabled = true;
        }


        // getters
        public int getId()
        {
            return this.TaskId;
        }

        public string getTitle()
        {
            return this.Title;
        }
        public string getDescription()
        {
            return this.Description;
        }
        public bool getEnabled()
        {
            return this.Enabled;
        }

        //setters
        public void setTitle(string title)
        {
            this.Title = title;
        }
        public void setDescription(string desc)
        {
            this.Description = desc;
        }
        public void setEnabled(bool enabled)
        {
            this.Enabled = enabled;
        }


        public void setId(int id)
        {
            this.TaskId = id;
        }
    }
}
