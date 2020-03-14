using System;
using AutoFixture.Kernel;
using Shouldly;

namespace DaBeerStorage.Tests.ViewModels
{
    public class BaseMappingTest
    {
        public void VerifyMappings<T>(T className)
        {
            foreach (var property in className.GetType().GetProperties())
            {
                var type = property.GetType();

                if (property.PropertyType == typeof(string))
                {
                    var check = (string)property.GetValue(className);
                    check.ShouldNotBeNullOrEmpty();
                }
                else if (property.PropertyType == typeof(bool?))
                {
                    var check = (bool?)property.GetValue(className);
                    check.HasValue.ShouldBeOfType<bool>();
                }
                else if (property.PropertyType == typeof(DateTimeOffset))
                {
                    var check = (DateTimeOffset)property.GetValue(className);
                    check.ShouldNotBe(DateTimeOffset.MinValue);
                }
            }
        }

        public void VerifyMappingValues<T, V>(T mapFromClass, V coreClass)
        {
            foreach (var property in mapFromClass.GetType().GetProperties())
            {
                
            }
        }
    }
}