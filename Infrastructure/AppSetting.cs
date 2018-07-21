namespace Infrastructure
{
    /// <summary>
    /// 配置项
    /// </summary>
    public class AppSetting
    {
        /// <summary>
        /// Session 最大存活周期
        /// </summary>
        public int UserSessionMaxLife { get; set; }

        public int UserSessionMinLife { get; set; }

        public int UserSessionMaxActiveTime { get; set; }

        public string backSiteDomain { get; set; }

        public int enableUSBKEYLOGIN { get; set; }

        public int enableEncryptConnectionString { get; set; }

        public string KnowledgeCenterDownloadPath { get; set; }

        public string InfomationCenterDownloadPath { get; set; }

        public int DataSubscribeDDTimerInterval { get; set; }

        public int DataSubscribeMMTimerInterval { get; set; }

        public int StatTimerMonth { get; set; }

        public int StatTimerDay { get; set; }

        public int SubscribeTimerDelay { get; set; }

        public int SubscribeTimerInterval { get; set; }

        public string SMSUserID { get; set; }

        public string SMSPassword { get; set; }

        public long FILE_MAX_SIZE_LOG { get; set; }

        public string LOG_FILE_NAME_SYSTEM { get; set; }

        public string LOG_FILE_NAME_LOGIN { get; set; }

        public string FILE_PATH_LOG { get; set; }

        public string FILE_PATH_LOG_BAK { get; set; }

        public string EXCEL_SAVE_PATH { get; set; }

        public string EXCEL_TEMPLATE_PATH { get; set; }

        public string DependencyFile { get; set; }

        public bool CrystalImageCleanerAutoStart { get; set; }

        public int CrystalImageCleanerSleep { get; set; }

        public int CrystalImageCleanerAge { get; set; }

        public bool SendMessageSwitch { get; set; }

        public int SendMessageScanTime { get; set; }

        public string SendMessageURL { get; set; }

        public string ChartHttpHandler { get; set; }

        public string SetLicenseDisabledForSaaS { get; set; }

        public string VerNameGuid { get; set; }
    }
}
