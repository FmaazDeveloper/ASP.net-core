//using Microsoft.EntityFrameworkCore;
//using System.ComponentModel.DataAnnotations;
//using UserManagementWithIdentity.Data;

//namespace UserManagementWithIdentity.Helpers
//{

//    public class ExistsAttribute : ValidationAttribute
//    {
//        private readonly Type _entityType;

//        private readonly string _propertyName;



//        public ExistsAttribute(Type entityType, string propertyName = "Id")

//        {

//            _entityType = entityType;

//            _propertyName = propertyName;

//        }

//        protected override ValidationResult IsValid(object value, ValidationContext validationContext)

//        {

//            var dbContext = validationContext.GetService<ApplicationDbContext>();

//            if (dbContext == null)

//            {

//                throw new InvalidOperationException("DbContext is not available.");

//            }

//            var dbSet = dbContext.GetType().GetMethod("Set")!.MakeGenericMethod(_entityType).Invoke(dbContext, null);

//            //var entity = dbSet.GetType().GetMethod("SingleOrDefault", new Type[] { typeof(object[]) }).Invoke(dbSet, new object[] { new object[] { value } });

//            if (entity == null)

//            {

//                return new ValidationResult($"The {_entityType.Name} with {_propertyName} '{value}' does not exist.");

//            }



//            return ValidationResult.Success;

//        }

//    }
//}
