
namespace c_creator.Infrastructure
{
    static class Settings
    {
        static int _rowCount = 5;
        public static int RowCount { get { return _rowCount; } set { _rowCount = value; } }

        static string _ctrlFileName = "1_import.CTL";
        public static string CtrlFileName { get { return _ctrlFileName; } set { _ctrlFileName = value; } }

        static int _сommentStart = 40;
        public static int CommentStart { get { return _сommentStart; } set { _сommentStart = value; } }

        static bool _isRegister = true;
        public static bool IsRegister { get { return _isRegister; } set { _isRegister = value; } }
    }
}
