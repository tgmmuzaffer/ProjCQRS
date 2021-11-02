namespace ProjCQRS.Mvc.ApiStatics
{
    public class CqrsStatics
    {
        //ProductMediatrController
        public static string BaseUrl = "https://localhost:44361/";
        public static string GetCategories = BaseUrl + "api/categorymediatr/getcategories";
        public static string GetCategory = BaseUrl + "api/categorymediatr/getcategory/";
        public static string CreateCategory = BaseUrl + "api/categorymediatr/createcategory";
        public static string UpdateCategory = BaseUrl + "api/categorymediatr/updatecategory";
        public static string DeleteCategory = BaseUrl + "api/categorymediatr/deletecategory/";

        public static string GetProducts = BaseUrl + "api/productmediatr/getproducts";
        public static string GetProductsWithRange = BaseUrl + "api/productmediatr/getproductswithrange/";
        public static string GetProduct = BaseUrl + "api/productmediatr/getproduct/";
        public static string CreateProduct = BaseUrl + "api/productmediatr/createproduct";
        public static string UpdateProduct = BaseUrl + "api/productmediatr/updateproduct";
        public static string DeleteProduct = BaseUrl + "api/productmediatr/deleteproduct";
    }
}
