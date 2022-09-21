using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1;

public class ObjectCopier
{
    public T CopyObject<T>(T ObjectToCopy)
    {
        T coppiedObject = (T)Activator.CreateInstance(ObjectToCopy.GetType());

        var propertiesOfObjectToCopy = typeof(T).GetProperties();

        foreach (var property in propertiesOfObjectToCopy)
        {
            var propertyValue = property.GetValue(ObjectToCopy);
            property.SetValue(coppiedObject, propertyValue);
        }

        Console.WriteLine(coppiedObject.ToString());

        return coppiedObject;
    }
}
