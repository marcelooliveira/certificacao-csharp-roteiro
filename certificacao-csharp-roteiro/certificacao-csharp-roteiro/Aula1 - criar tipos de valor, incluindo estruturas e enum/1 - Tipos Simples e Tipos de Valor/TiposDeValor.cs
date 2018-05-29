using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposDeValor
    {
        //Main Features of Value Types
        //Variables that are based on value types directly contain values.

        //C# Type	.NET Framework Type
        //=============================
        //bool       System.Boolean
        //byte       System.Byte
        //sbyte      System.SByte
        //char       System.Char
        //decimal    System.Decimal
        //double     System.Double
        //float      System.Single
        //int        System.Int32
        //uint       System.UInt32
        //long       System.Int64
        //ulong      System.UInt64
        //short      System.Int16
        //ushort     System.UInt16


        //Assigning one value type variable to another copies the contained value.This differs from the 
        //assignment of reference type variables, which copies a reference to the object but not the object itself.

        //All value types are derived implicitly from the System.ValueType.

        //Unlike with reference types, you cannot derive a new type from a value type.However, 
        //like reference types, structs can implement interfaces.

        //Unlike reference types, a value type cannot contain the null value.However, the nullable 
        //types feature does allow for value types to be assigned to null.

        //Each value type has an implicit default constructor that initializes the default value of 
        //that type. For information about default values of value types, see Default Values Table.

        //Initializing Value Types
        //Local variables in C# must be initialized before they are used. For example, you might declare a 
        //local variable without initialization as in the following example:

        //int myInt;
        //You cannot use it before you initialize it.You can initialize it using the following statement:

        //myInt = new int ();  // Invoke default constructor for int type.  
        //This statement is equivalent to the following statement:

        //myInt = 0;         // Assign an initial value, 0 in this example.  
        //You can, of course, have the declaration and the initialization in the same statement as in the 
        //following examples:

        //int myInt = new int();  

        //–or–

        //int myInt = 0;

        //Using the new operator calls the default constructor of the specific type and assigns the default 
        //value to the variable. In the preceding example, the default constructor assigned the value 0 to myInt. 
        //    For more information about values assigned by calling default constructors, see Default Values Table.

        //With user-defined types, use new to invoke the default constructor.For example, the following statement 
        //invokes the default constructor of the Point struct:

        //Point p = new Point(); // Invoke default constructor for the struct.  
        //After this call, the struct is considered to be definitely assigned; that is, all its members are 
        //initialized to their default values.

        //For more information about the new operator, see new.

        //For information about formatting the output of numeric types, see Formatting Numeric Results Table.
    }
}
