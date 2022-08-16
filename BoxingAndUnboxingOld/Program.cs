using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Types in C#:
 * Value types
 * Reference types


   Value Types:
    * stored on the stack
    * all primitive types: byte, int, float, char, bool
    * struct type

   Reference Types:
    * stored on the heap
    * any classes - object, array, string, DbMigrator etc.


Boxing:
    * process of converting a value type instance to an object reference

int number = 10;
object obj = number;

or
object obj = 10; // value is stored in the heap instead of the stack


Unboxing:
    * opposite of boxing

object obj = 10;
int number = (int)obj;


Boxing / Unboxing:
    * have a performance penalty

 */

namespace BoxingAndUnboxingOld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("String");
            list.Add(DateTime.Today);
            //typing various types into the list we loose type safety

            //var number = (int)list[1];

            var anotherList = new List<int>();
            //anotherList.Add(1); // list stores a list of integers not objects like the one above
            var names = new List<string>();
            //names.Add();
        }
    }
}
