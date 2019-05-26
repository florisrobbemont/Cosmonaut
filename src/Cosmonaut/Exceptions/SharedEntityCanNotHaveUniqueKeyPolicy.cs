using System;

namespace Cosmonaut.Exceptions
{
    public class SharedEntityCanNotHaveUniqueKeyPolicy : Exception
    {
        public SharedEntityCanNotHaveUniqueKeyPolicy(Type type) : base($"Shared entity {type.Name} is setup using a unique key policy. This is not possible due to the fact that other entities might not have this property.")
        {

        }
    }
}