using System;

namespace CustomAnnotationApp
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class NeedToRefactorAttribute : Attribute { }
}