namespace Day5.SelfStudy;

class Main
{
    public static void Index()
    {
        /*
            * - Constructor child call parameterless constructor parent 
            *   after that call own constrictor by default.
            */
        #region SimpleInheritance
        Runner("SimpleInheritance", new KeyValuePair<string, Action>[] {
            new ("Parent Class", SimpleInheritance.Main.Parent),
            new ("Child Class", SimpleInheritance.Main.Child)
        });
        #endregion

        /*
            * - You can access child members from child instance.
            * - You can access parent members from parent, no access to child members.
            */
        #region InheritanceWithChildArgs
        Runner("InheritanceWithChildMembers", new KeyValuePair<string, Action>[] {
            new ("Parent Class", InheritanceWithChildMembers.Main.Parent),
            new ("Child Class", InheritanceWithChildMembers.Main.Child)
        });
        #endregion

        /*
            * - You can access child and parent members from child instance.
            * - You can access parent members from parent, no access to child members.
            * - Can target any constructor you want use base keyword.
            */
        #region InheritanceWithParentMembers
        Runner("InheritanceWithParentMembers", new KeyValuePair<string, Action>[] {
            new ("Parent Class", InheritanceWithParentMembers.Main.Parent),
            new ("Child Class", InheritanceWithParentMembers.Main.Child)
        });
        #endregion

        /*
            * - Can hide parent method and make your own method same name.
            * - Using new keyword (optional) to know this method hide parent method. 
            * - This active when Initialize child instance only to it self
            *   Child c = new Child();
            */
        #region HideMethod
        Runner("HideMethod", new KeyValuePair<string, Action>[] {
            new ("Parent Class", HideMethod.Main.Parent),
            new ("Child Class", HideMethod.Main.Child),
            new ("Parent Class With Instance Child Class",  HideMethod.Main.ParentEqualChildInstance)
        });
        #endregion

        /*
            * - You can override the method by using virtual keyword in parent method 
            *   and if this method dose not exists in child this method calls by default.
            * - This effect in two initialize 
            *      - Child c = new Child();
            *      - Parent p = new Child();
            * - Not effect in parent when make instance with it Parent p = new Parent();
            */
        #region VirtualAndOverride
        Runner("VirtualAndOverride", new KeyValuePair<string, Action>[] {
            new ("Parent Class", VirtualAndOverride.Main.Parent),
            new ("Child Class", VirtualAndOverride.Main.Child),
            new ("Parent Class With Instance Child Class",  VirtualAndOverride.Main.ParentEqualChildInstance)
        });
        #endregion

        /*
            * - Yes, you can inherit from child and and new child can make child's and so on. 
            * - Override if hidden by using new keyword and make hide function class child's can not override to this function 
            *   can make anther hide function or add to class virtual keyword with new to can override it again.
            */
        #region MultiInheritance
        Runner("MultiInheritance", new KeyValuePair<string, Action>[] {
            new ("Parent Class", MultiInheritance.Main.Parent),
            new ("Child Class", MultiInheritance.Main.Child),
            new ("Parent Class With Instance Child Class",  MultiInheritance.Main.ParentEqualChildInstance),
            new ("SubChild Class",  MultiInheritance.Main.SubChild)
        });
        #endregion
    }

    #region HelperFunctions
    // This function help to print to screen 
    public static void Runner(string title, KeyValuePair<string, Action>[] pairs)
    {
        Console.WriteLine("=======================================");
        Console.WriteLine($"# {title}");
        Console.WriteLine("=======================================");

        foreach (var pair in pairs)
        {
            Console.WriteLine($"- {pair.Key}");
            pair.Value();
            Console.WriteLine("---------------------------------------");
        }

        Console.WriteLine("\n\n");
    }
    #endregion
}
