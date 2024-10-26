using DependencyInjection;

ProductManager productManager = new(new NhProductDal());
productManager.Save();