using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint : generic kısıtlama
    //class: referans tip
    //IEntity: T, bir referans tip olmalı ve T ya IEntity olabilir ya da IEntityden implemente edilen bir nesne olabilir.
    //IEntity yi de devre dısı bırakmak istiyorum."new()" ekledik.
    //new : new lenwbilir olmalı
    //Suan da sistemimiz sadece veri tabanı nesneleriyle calısıyor
    public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null); //espression filtreleme yapmamızı saglar. linq ile beraber gelen bir yapı.
        T Get(Expression<Func<T, bool>> filter);  //T tipinde bisey döndürücek(Product yada Category). burda filtre zorunlu 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
