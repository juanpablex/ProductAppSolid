using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Authentication;
using Business.Repositories.CategoryRepository;
using Business.Repositories.EmailParameterRepository;
using Business.Repositories.GroupRepository;
using Business.Repositories.MeasurementRepository;
using Business.Repositories.MeasurementTypeRepository;
using Business.Repositories.OperationClaimRepository;
using Business.Repositories.PersonRepository;
using Business.Repositories.PrivilegeRepository;
using Business.Repositories.ProductRepository;
using Business.Repositories.ProductStoreRepository;
using Business.Repositories.ProductTypeRepository;
using Business.Repositories.StateRepository;
using Business.Repositories.StateTypeRepository;
using Business.Repositories.StoreRepository;
using Business.Repositories.StoreTypeRepository;
using Business.Repositories.UserOperationClaimRepository;
using Business.Repositories.UserPersonRepository;
using Business.Repositories.UserRepository;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Repositories.CategoryRepository;
using DataAccess.Repositories.EmailParameterRepository;
using DataAccess.Repositories.GroupRepository;
using DataAccess.Repositories.MeasurementRepository;
using DataAccess.Repositories.MeasurementTypeRepository;
using DataAccess.Repositories.OperationClaimRepository;
using DataAccess.Repositories.PersonRepository;
using DataAccess.Repositories.PrivilegeRepository;
using DataAccess.Repositories.ProductRepository;
using DataAccess.Repositories.ProductStoreRepository;
using DataAccess.Repositories.ProductTypeRepository;
using DataAccess.Repositories.StateRepository;
using DataAccess.Repositories.StateTypeRepository;
using DataAccess.Repositories.StoreRepository;
using DataAccess.Repositories.StoreTypeRepository;
using DataAccess.Repositories.UserOperationClaimRepository;
using DataAccess.Repositories.UserPersonRepository;
using DataAccess.Repositories.UserRepository;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>();
            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>();

            builder.RegisterType<EmailParameterManager>().As<IEmailParameterService>();
            builder.RegisterType<EfEmailParameterDal>().As<IEmailParameterDal>();

            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<ProductTypeManager>().As<IProductTypeService>();
            builder.RegisterType<EfProductTypeDal>().As<IProductTypeDal>();
            
            builder.RegisterType<StateTypeManager>().As<IStateTypeService>();
            builder.RegisterType<EfStateTypeDal>().As<IStateTypeDal>();

            builder.RegisterType<Repositories.StateRepository.StateManager>().As<IStateService>();
            builder.RegisterType<EfStateDal>().As<IStateDal>();

            builder.RegisterType<StoreTypeManager>().As<IStoreTypeService>();
            builder.RegisterType<EfStoreTypeDal>().As<IStoreTypeDal>();

            builder.RegisterType<StoreManager>().As<IStoreService>();
            builder.RegisterType<EfStoreDal>().As<IStoreDal>();

            builder.RegisterType<PersonManager>().As<IPersonService>();
            builder.RegisterType<EfPersonDal>().As<IPersonDal>();

            builder.RegisterType<GroupManager>().As<IGroupService>();
            builder.RegisterType<EfGroupDal>().As<IGroupDal>();

            builder.RegisterType<PrivilegeManager>().As<IPrivilegeService>();
            builder.RegisterType<EfPrivilegeDal>().As<IPrivilegeDal>();

            builder.RegisterType<MeasurementTypeManager>().As<IMeasurementTypeService>();
            builder.RegisterType<EfMeasurementTypeDal>().As<IMeasurementTypeDal>();

            builder.RegisterType<MeasurementManager>().As<IMeasurementService>();
            builder.RegisterType<EfMeasurementDal>().As<IMeasurementDal>();

            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<ProductStoreManager>().As<IProductStoreService>();
            builder.RegisterType<EfProductStoreDal>().As<IProductStoreDal>();

            builder.RegisterType<UserPersonManager>().As<IUserPersonService>();
            builder.RegisterType<EfUserPersonDal>().As<IUserPersonDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();

            builder.RegisterType<TokenHandler>().As<ITokenHandler>();

         

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new Castle.DynamicProxy.ProxyGenerationOptions()
            {
                Selector = new AspectInterceptorSelector()
            }).SingleInstance();
        }
    }
}
