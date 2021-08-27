using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class Unit16
    {
        sealed public class Adam : Male
        {
            private static Adam _instance;
            public static Adam GetInstance() => _instance ??= new Adam("Adam");

            private Adam(string name) : base(name, null, null) { }

            // Why adam has parent? because adam's parent is GOD.
            protected override bool HasParent => true;
        }
        sealed public class Eve : Female
        {
            private static Eve _instance;
            public static Eve GetInstance(Adam adam)
            {
                if (adam == null) throw new ArgumentNullException(nameof(adam));

                return _instance ??= new Eve("Eve");
            }

            private Eve(string name) : base(name, null, null) {  }

            // Why eve has parent? because eve's parent is Adam.
            protected override bool HasParent => true;
        }
        public class Male : Human
        {
            public Male(string name, Female mother, Male father) : base(name, mother, father) { }
        }
        public class Female : Human
        {
            public Female(string name, Female mother, Male father) : base(name, mother, father) { }
        }
        public abstract class Human
        {
            public string Name;
            public Human Mother;
            public Human Father;

            public Human(string name, Human mother, Human father)
            {
                Name = name;
                Father = father;
                Mother = mother;
                if (!HasParent) throw new ArgumentNullException();
            }

            protected virtual bool HasParent => Mother != null && Father != null;
        }
    }
}
