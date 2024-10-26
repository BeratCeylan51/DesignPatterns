
using AbstractFactory;

ProductManager productManager = new ProductManager(new Factory1());
productManager.GetAll();