using Business.Aspects.Secured;
using Business.Repositories.CategoryRepository.Constants;
using Business.Repositories.CategoryRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.CategoryRepository;
using Entities.Concrete;

namespace Business.Repositories.CategoryRepository
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(CategoryValidator))]
        [RemoveCacheAspect("ICategoryService.Get")]
        public async Task<IResult> Add(Category category)
        {
            await _categoryDal.Add(category);
            return new SuccessResult(CategoryMessages.AddedCategory);
        }

        //[SecuredAspect()]
        [RemoveCacheAspect("ICategoryService.Get")]
        public async Task<IResult> Delete(Category category)
        {
            await _categoryDal.Delete(category);
            return new SuccessResult(CategoryMessages.DeletedCategory);
        }

        public async Task<IDataResult<Category>> GetById(int id)
        {
            return new SuccessDataResult<Category>(await _categoryDal.Get(p => p.Id == id));
        }

        public async Task<Category> GetFirst()
        {
            return await _categoryDal.GetFirst();
        }

        [CacheAspect()]
        public async Task<IDataResult<List<Category>>> GetList()
        {
            return new SuccessDataResult<List<Category>>(await _categoryDal.GetAll());
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(CategoryValidator))]
        [RemoveCacheAspect("ICategoryService.Get")]
        public async Task<IResult> Update(Category category)
        {
            await _categoryDal.Update(category);
            return new SuccessResult(CategoryMessages.UpdatedCategory);
        }
    }
}
