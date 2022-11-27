using System;

namespace LeonComputing_BL
{
    public static class CurrentUser
    {
        public static int Id { set; get; }
        public static string Username { set; get; }
        public static string Firstname { set; get; }
        public static string Middle_name { set; get; }
        public static string Lastname { set; get; }
        public static string Lastname_second { set; get; }
        public static DateTime? Birthday { set; get; }
        public static string Email { set; get; }
    }
}
