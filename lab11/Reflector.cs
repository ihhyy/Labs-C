using System;
using System.Text;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;



namespace lab12
{
    static class Reflector
    {
        public static IEnumerable<string> GetMethods()
        {
            IEnumerable<string> methods;
            Type type = Type.GetType("lab12.Ex1");
            MemberInfo[] members = type.GetMethods();

            methods = from member in members
                      select member.ToString();

            return methods;
        }

        public static void GetName() 
        {
            Type type = Type.GetType("lab12.Ex1");
            Console.WriteLine(type.FullName);
        }

        public static void GetConstructors()
        {
            Type type = Type.GetType("lab12.Ex1");
            if (type.GetConstructors() != null)
            {
                Console.WriteLine("exicts");
            }
        }

        public static IEnumerable<string> GetFields()
        {
            IEnumerable<string> fields;
            Type type = Type.GetType("lab12.Ex1");
            MemberInfo[] members = type.GetFields();
            fields = from member in members
                     select member.ToString();
            return fields;
        }
        
        public static IEnumerable<string> GetInterfaces()
        {
            IEnumerable<string> interfaces;
            Type type = Type.GetType("lab12.Ex1");
            MemberInfo[] members = type.GetInterfaces();
            interfaces = from member in members
                         select member.ToString();
            return interfaces;
        }

        public static IEnumerable<string> GetChosenMethods(Type _type, string chosenClass)
        {
            IEnumerable<string> methods;
            Type type = Type.GetType($"lab12.{chosenClass}");
            methods = from member in type.GetMethods()
                        from m1 in member.GetParameters()
                        where m1.ParameterType == _type
                      select member.ToString();
            return methods;
        }

        public static void Invoke()
        {
            Assembly asm = Assembly.LoadFrom("C:\\ex\\Ex.dll");
            Type typeM = asm.GetType("Ex.Program");
            Type typeF = Type.GetType("lab12.Ex1");

            object obj = Activator.CreateInstance(typeM);
            MethodInfo method = typeM.GetMethod("Sum");


            FieldInfo fld1 = typeF.GetField("value1");
            FieldInfo fld2 = typeF.GetField("value2");


            var value = method.Invoke(obj, new object[] {fld1.GetValue(null), fld2.GetValue(null) });
            Console.WriteLine(value);
        }
    }

    class Creator
    {
        public static object Info( object[] values)
        {
            Type[] parameters = new Type[] { typeof(string) };
            ConstructorInfo info = typeof(Ex4).GetConstructor(parameters);
            var obj = info.Invoke(values);

            return obj;
        }
    }
}
