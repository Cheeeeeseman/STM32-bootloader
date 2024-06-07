/** 
 * @file AppConsts
 * @brief Файл содержит константы
 */

namespace swBootloader
{
    public static class AppConsts
    {
        #region paths
        public const string JSON_PATH = "..\\..\\..\\..\\JSON\\config.json";
        #endregion paths
        #region packet_consts
        public const int PACKET_HEADER = 0x80;
        public const int PACKET_DATA_MAX_SIZE = 256;
        #endregion packet_consts
        #region Boot_CMD
        public const int CMD_WRITE_SOFTWARE = 0x01;
        public const int CMD_BOOT_WHO_AM_I  = 0x02;
        public const int CMD_SOFT_WHO_AM_I  = 0x03;
        #endregion Boot_CMD
        #region packet_size
        public const int PACK_SIZE_BOOT_WHO_AM_I = 8;
        public const int PACK_SIZE_SOFT_WHO_AM_I = 8;
        #endregion packet_size
        #region util
        public const int MAX_ERRORS_AMOUNT = 0x05;
        #endregion util
    }
}
