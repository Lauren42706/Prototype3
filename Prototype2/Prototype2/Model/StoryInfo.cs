using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Prototype2.Model
{
    public partial class StoryInfo
    {
        public static implicit operator ObservableCollection<object>(StoryInfo v)
        {
            throw new NotImplementedException();
        }

        public class CharacterInfo
        {
            public string CharacterName { get; set; }
            
        }
        public class BackgroundInfo
        {
            public string BackgroundName { get; set; }
        }
    }
}
