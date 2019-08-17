namespace JRSolutionsFac.Repository.Helpers
{
    public static class STORE_PROCEDURES
    {
        public static string PRC_GET_USERS = "[dbo].[Get_Users]";
        public static string PRC_GET_PRODUCTS = "[dbo].[Get_Producto]";
        public static string PRC_GET_FACTURAS = "[dbo].[Get_facturas]";

        public static string PRC_GET_FACTURA_BY_ID = "[dbo].[Get_ReportFacturaHead]";
        public static string PRC_GET_FACTURADET_BY_ID = "[dbo].[Get_ReportFacturaDetail]";

        public static string PRC_GET_MARCAS = "[dbo].[Get_Marcas]";
        public static string PRC_SET_FACTURA = "[dbo].[Set_Factura]";
        public static string PRC_SET_FACTURA_DETALLE = "[dbo].[Set_Factura_Detalle]";
        
        public static string PRC_GET_ALL_FT = "PKG_OMS_CF_MAESTRO.PRC_GET_ALL_FT";

        public static string PRC_GET_FACTURAS_FILTER = "[dbo].[Get_facturas_filter]";
        public static string PRC_GET_SERVICIOS_FILTER = "[dbo].[Get_Producto_Filter]";
    }
}
