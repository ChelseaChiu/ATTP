using ATTP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ATTP.Resources;
using ATTP.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace ATTP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> menuList { get; set; }

        public ObservableCollection<Language> Languages { get; } 
        public ObservableCollection<Language> ShortName { get; }

        public MainPage()
        {
            InitializeComponent();
            menuList = new List<MasterPageItem>();

            switch (App._language)
            {
                // Im aware this is the lazy method that requires alot more work but im tired and lazy rn Kimi

                case "zh-Hans":
                    {
                        menuList.Add(new MasterPageItem() { Title = "主页", ImageSource = "Home.png", TargetType = typeof(HomePage) });
                        menuList.Add(new MasterPageItem() { Title = "结果页", ImageSource = "Result.png", TargetType = typeof(ResultPage) });
                        menuList.Add(new MasterPageItem() { Title = "成绩单页", ImageSource = "Transcript.png", TargetType = typeof(TransciptPage) });
                        menuList.Add(new MasterPageItem() { Title = "课程表", ImageSource = "Calendar.png", TargetType = typeof(TimetablePage) });
                        menuList.Add(new MasterPageItem() { Title = "个人资料页", ImageSource = "Profile.png", TargetType = typeof(ProfilePage) });
                        // frick just frick
                        menuList.Add(new MasterPageItem() { Title = "电子邮件", ImageSource = "Email.png", TargetType = typeof(Email) });
                        menuList.Add(new MasterPageItem() { Title = "校园目录", ImageSource = "Campus.png", TargetType = typeof(CampusDirectory) });
                        menuList.Add(new MasterPageItem() { Title = "讲师信息", ImageSource = "Lecturer.png", TargetType = typeof(LecturerInfo) });

                        menuList.Add(new MasterPageItem() { Title = "登出", ImageSource = "Exit.png", TargetType = typeof(LoginPage) });
                        // Setting our list to be ItemSource for ListView in MainPage.xaml
                        navigationDrawerList.ItemsSource = menuList;
                        // Initial navigation, this can be used for our home page
                        Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
                        break;
                    }
                case "zh-Hant":
                    {
                        menuList.Add(new MasterPageItem() { Title = "主頁", ImageSource = "Home.png", TargetType = typeof(HomePage) });
                        menuList.Add(new MasterPageItem() { Title = "結果頁", ImageSource = "Result.png", TargetType = typeof(ResultPage) });
                        menuList.Add(new MasterPageItem() { Title = "筆錄頁面", ImageSource = "Transcript.png", TargetType = typeof(TransciptPage) });
                        menuList.Add(new MasterPageItem() { Title = "課程表", ImageSource = "Calendar.png", TargetType = typeof(TimetablePage) });
                        menuList.Add(new MasterPageItem() { Title = "個人資料頁", ImageSource = "Profile.png", TargetType = typeof(ProfilePage) });

                        // frick just frick
                        menuList.Add(new MasterPageItem() { Title = "電子郵件", ImageSource = "Email.png", TargetType = typeof(Email) });
                        menuList.Add(new MasterPageItem() { Title = "校園目錄", ImageSource = "Campus.png", TargetType = typeof(CampusDirectory) });
                        menuList.Add(new MasterPageItem() { Title = "講師信息", ImageSource = "Lecturer.png", TargetType = typeof(LecturerInfo) });

                        menuList.Add(new MasterPageItem() { Title = "登出", ImageSource = "Exit.png", TargetType = typeof(LoginPage) });
                        // Setting our list to be ItemSource for ListView in MainPage.xaml
                        navigationDrawerList.ItemsSource = menuList;
                        // Initial navigation, this can be used for our home page
                        Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
                        break;
                    }
                case "en":
                    {
                        menuList.Add(new MasterPageItem() { Title = "Home", ImageSource = "Home.png", TargetType = typeof(HomePage) });
                        menuList.Add(new MasterPageItem() { Title = "Result", ImageSource = "Result.png", TargetType = typeof(ResultPage) });
                        menuList.Add(new MasterPageItem() { Title = "Transcript", ImageSource = "Transcript.png", TargetType = typeof(TransciptPage) });
                        menuList.Add(new MasterPageItem() { Title = "Time Table", ImageSource = "Calendar.png", TargetType = typeof(TimetablePage) });
                        menuList.Add(new MasterPageItem() { Title = "Profile", ImageSource = "Profile.png", TargetType = typeof(ProfilePage) });

                        // frick just frick
                        menuList.Add(new MasterPageItem() { Title = "Email", ImageSource = "Email.png", TargetType = typeof(Email) });
                        menuList.Add(new MasterPageItem() { Title = "Campus Directory", ImageSource = "Campus.png", TargetType = typeof(CampusDirectory) });
                        menuList.Add(new MasterPageItem() { Title = "Lecturer Infomation", ImageSource = "Lecturer.png", TargetType = typeof(LecturerInfo) });

                        menuList.Add(new MasterPageItem() { Title = "Log Out", ImageSource = "Exit.png", TargetType = typeof(LoginPage) });
                        // Setting our list to be ItemSource for ListView in MainPage.xaml
                        navigationDrawerList.ItemsSource = menuList;
                        // Initial navigation, this can be used for our home page
                        Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
                        break;
                    }
                case "mn-MN":
                    {
                        menuList.Add(new MasterPageItem() { Title = "Нүүр хуудас", ImageSource = "Home.png", TargetType = typeof(HomePage) });
                        menuList.Add(new MasterPageItem() { Title = "Үр дүнгийн хуудас", ImageSource = "Result.png", TargetType = typeof(ResultPage) });
                        menuList.Add(new MasterPageItem() { Title = "Орчуулах хуудас", ImageSource = "Transcript.png", TargetType = typeof(TransciptPage) });
                        menuList.Add(new MasterPageItem() { Title = "хичээлийн хуваарь", ImageSource = "Calendar.png", TargetType = typeof(TimetablePage) });
                        menuList.Add(new MasterPageItem() { Title = "Профайл хуудас", ImageSource = "Profile.png", TargetType = typeof(ProfilePage) });

                        // frick just frick
                        menuList.Add(new MasterPageItem() { Title = "И - мэйл", ImageSource = "Email.png", TargetType = typeof(Email) });
                        menuList.Add(new MasterPageItem() { Title = "Кампусын лавлах", ImageSource = "Campus.png", TargetType = typeof(CampusDirectory) });
                        menuList.Add(new MasterPageItem() { Title = "Лекцийн мэдээлэл", ImageSource = "Lecturer.png", TargetType = typeof(LecturerInfo) });

                        menuList.Add(new MasterPageItem() { Title = "Log Out", ImageSource = "Exit.png", TargetType = typeof(LoginPage) });
                        // Setting our list to be ItemSource for ListView in MainPage.xaml
                        navigationDrawerList.ItemsSource = menuList;
                        // Initial navigation, this can be used for our home page
                        Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
                        break;
                    }

                case "ms":
                    {
                        menuList.Add(new MasterPageItem() { Title = "Halaman Utama", ImageSource = "Home.png", TargetType = typeof(HomePage) });
                        menuList.Add(new MasterPageItem() { Title = "Halaman Keputusan", ImageSource = "Result.png", TargetType = typeof(ResultPage) });
                        menuList.Add(new MasterPageItem() { Title = "Halaman Transkrip", ImageSource = "Transcript.png", TargetType = typeof(TransciptPage) });
                        menuList.Add(new MasterPageItem() { Title = "Jadual waktu", ImageSource = "Calendar.png", TargetType = typeof(TimetablePage) });
                        menuList.Add(new MasterPageItem() { Title = "Halaman Profil", ImageSource = "Profile.png", TargetType = typeof(ProfilePage) });
                        // frick just frick
                        menuList.Add(new MasterPageItem() { Title = "E-mel", ImageSource = "Email.png", TargetType = typeof(Email) });
                        menuList.Add(new MasterPageItem() { Title = "Direktori Kampus", ImageSource = "Campus.png", TargetType = typeof(CampusDirectory) });
                        menuList.Add(new MasterPageItem() { Title = "Maklumat Pensyarah", ImageSource = "Lecturer.png", TargetType = typeof(LecturerInfo) });

                        menuList.Add(new MasterPageItem() { Title = "Log keluar", ImageSource = "Exit.png", TargetType = typeof(LoginPage) });
                        // Setting our list to be ItemSource for ListView in MainPage.xaml
                        navigationDrawerList.ItemsSource = menuList;
                        // Initial navigation, this can be used for our home page
                        Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
                        break;
                    }
                case "fr":
                    {
                        menuList.Add(new MasterPageItem() { Title = "Page d'accueil", ImageSource = "Home.png", TargetType = typeof(HomePage) });
                        menuList.Add(new MasterPageItem() { Title = "Page de résultats", ImageSource = "Result.png", TargetType = typeof(ResultPage) });
                        menuList.Add(new MasterPageItem() { Title = "Page de transcription", ImageSource = "Transcript.png", TargetType = typeof(TransciptPage) });
                        menuList.Add(new MasterPageItem() { Title = "Time Table", ImageSource = "Calendar.png", TargetType = typeof(TimetablePage) });
                        menuList.Add(new MasterPageItem() { Title = "Page de profil", ImageSource = "Profile.png", TargetType = typeof(ProfilePage) });
                        // frick just frick
                        menuList.Add(new MasterPageItem() { Title = "Email", ImageSource = "Email.png", TargetType = typeof(Email) });
                        menuList.Add(new MasterPageItem() { Title = "Annuaire Campus", ImageSource = "Campus.png", TargetType = typeof(CampusDirectory) });
                        menuList.Add(new MasterPageItem() { Title = "Informations sur le conférencier", ImageSource = "Lecturer.png", TargetType = typeof(LecturerInfo) });

                        menuList.Add(new MasterPageItem() { Title = "Se déconnecter", ImageSource = "Exit.png", TargetType = typeof(LoginPage) });
                        // Setting our list to be ItemSource for ListView in MainPage.xaml
                        navigationDrawerList.ItemsSource = menuList;
                        // Initial navigation, this can be used for our home page
                        Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));

                        break;
                    }
                case "de":
                    {
                        menuList.Add(new MasterPageItem() { Title = "Startseite", ImageSource = "Home.png", TargetType = typeof(HomePage) });
                        menuList.Add(new MasterPageItem() { Title = "Ergebnisseite", ImageSource = "Result.png", TargetType = typeof(ResultPage) });
                        menuList.Add(new MasterPageItem() { Title = "Transkript Seite", ImageSource = "Transcript.png", TargetType = typeof(TransciptPage) });
                        menuList.Add(new MasterPageItem() { Title = "Stundenplan", ImageSource = "Calendar.png", TargetType = typeof(TimetablePage) });
                        menuList.Add(new MasterPageItem() { Title = "Profilseite", ImageSource = "Profile.png", TargetType = typeof(ProfilePage) });
                        // frick just frick
                        menuList.Add(new MasterPageItem() { Title = "Email", ImageSource = "Email.png", TargetType = typeof(Email) });
                        menuList.Add(new MasterPageItem() { Title = "Campus-Verzeichnis", ImageSource = "Campus.png", TargetType = typeof(CampusDirectory) });
                        menuList.Add(new MasterPageItem() { Title = "Informationen für Dozenten", ImageSource = "Lecturer.png", TargetType = typeof(LecturerInfo) });

                        menuList.Add(new MasterPageItem() { Title = "Ausloggen", ImageSource = "Exit.png", TargetType = typeof(LoginPage) });
                        // Setting our list to be ItemSource for ListView in MainPage.xaml
                        navigationDrawerList.ItemsSource = menuList;
                        // Initial navigation, this can be used for our home page
                        Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
                        break;
                    }
                case "ja":
                    {
                        menuList.Add(new MasterPageItem() { Title = "ホームページ", ImageSource = "Home.png", TargetType = typeof(HomePage) });
                        menuList.Add(new MasterPageItem() { Title = "結果ページ", ImageSource = "Result.png", TargetType = typeof(ResultPage) });
                        menuList.Add(new MasterPageItem() { Title = "転写ページ", ImageSource = "Transcript.png", TargetType = typeof(TransciptPage) });
                        menuList.Add(new MasterPageItem() { Title = "タイムテーブル", ImageSource = "Calendar.png", TargetType = typeof(TimetablePage) });
                        menuList.Add(new MasterPageItem() { Title = "自己紹介ページ", ImageSource = "Profile.png", TargetType = typeof(ProfilePage) });
                        // frick just frick
                        menuList.Add(new MasterPageItem() { Title = "Eメール", ImageSource = "Email.png", TargetType = typeof(Email) });
                        menuList.Add(new MasterPageItem() { Title = "キャンパスディレクトリ", ImageSource = "Campus.png", TargetType = typeof(CampusDirectory) });
                        menuList.Add(new MasterPageItem() { Title = "レクチュラー・インフォメーション", ImageSource = "Lecturer.png", TargetType = typeof(LecturerInfo) });

                        menuList.Add(new MasterPageItem() { Title = "ログアウト", ImageSource = "Exit.png", TargetType = typeof(LoginPage) });
                        // Setting our list to be ItemSource for ListView in MainPage.xaml
                        navigationDrawerList.ItemsSource = menuList;
                        // Initial navigation, this can be used for our home page
                        Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
                        break;
                    }
                case "ko":
                    {
                        menuList.Add(new MasterPageItem() { Title = "홈페이지", ImageSource = "Home.png", TargetType = typeof(HomePage) });
                        menuList.Add(new MasterPageItem() { Title = "결과 페이지", ImageSource = "Result.png", TargetType = typeof(ResultPage) });
                        menuList.Add(new MasterPageItem() { Title = "대본 페이지", ImageSource = "Transcript.png", TargetType = typeof(TransciptPage) });
                        menuList.Add(new MasterPageItem() { Title = "시간표", ImageSource = "Calendar.png", TargetType = typeof(TimetablePage) });
                        menuList.Add(new MasterPageItem() { Title = "프로필 페이지", ImageSource = "Profile.png", TargetType = typeof(ProfilePage) });
                        // frick just frick
                        menuList.Add(new MasterPageItem() { Title = "이메일", ImageSource = "Email.png", TargetType = typeof(Email) });
                        menuList.Add(new MasterPageItem() { Title = "캠퍼스 디렉토리", ImageSource = "Campus.png", TargetType = typeof(CampusDirectory) });
                        menuList.Add(new MasterPageItem() { Title = "강사 정보", ImageSource = "Lecturer.png", TargetType = typeof(LecturerInfo) });

                        menuList.Add(new MasterPageItem() { Title = "로그 아웃", ImageSource = "Exit.png", TargetType = typeof(LoginPage) });
                        // Setting our list to be ItemSource for ListView in MainPage.xaml
                        navigationDrawerList.ItemsSource = menuList;
                        // Initial navigation, this can be used for our home page
                        Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
                        break;
                    }
                case "ru":
                    {
                        menuList.Add(new MasterPageItem() { Title = "Домашняя страница", ImageSource = "Home.png", TargetType = typeof(HomePage) });
                        menuList.Add(new MasterPageItem() { Title = "Страница результатов", ImageSource = "Result.png", TargetType = typeof(ResultPage) });
                        menuList.Add(new MasterPageItem() { Title = "Стенограмма страницы", ImageSource = "Transcript.png", TargetType = typeof(TransciptPage) });
                        menuList.Add(new MasterPageItem() { Title = "Расписание уроков", ImageSource = "Calendar.png", TargetType = typeof(TimetablePage) });
                        menuList.Add(new MasterPageItem() { Title = "Страница профиля", ImageSource = "Profile.png", TargetType = typeof(ProfilePage) });
                        // frick just frick
                        menuList.Add(new MasterPageItem() { Title = "Эл. адрес", ImageSource = "Email.png", TargetType = typeof(Email) });
                        menuList.Add(new MasterPageItem() { Title = "Справочник кампуса", ImageSource = "Campus.png", TargetType = typeof(CampusDirectory) });
                        menuList.Add(new MasterPageItem() { Title = "Информация лектора", ImageSource = "Lecturer.png", TargetType = typeof(LecturerInfo) });

                        menuList.Add(new MasterPageItem() { Title = "выйти", ImageSource = "Exit.png", TargetType = typeof(LoginPage) });
                        // Setting our list to be ItemSource for ListView in MainPage.xaml
                        navigationDrawerList.ItemsSource = menuList;
                        // Initial navigation, this can be used for our home page
                        Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
                        break;
                    }
                case "th":
                    {
                        menuList.Add(new MasterPageItem() { Title = "หน้าแรก", ImageSource = "Home.png", TargetType = typeof(HomePage) });
                        menuList.Add(new MasterPageItem() { Title = "หน้าผลลัพท์", ImageSource = "Result.png", TargetType = typeof(ResultPage) });
                        menuList.Add(new MasterPageItem() { Title = "หน้าการถอดเสียง", ImageSource = "Transcript.png", TargetType = typeof(TransciptPage) });
                        menuList.Add(new MasterPageItem() { Title = "ตารางเวลา", ImageSource = "Calendar.png", TargetType = typeof(TimetablePage) });
                        menuList.Add(new MasterPageItem() { Title = "หน้าโปรไฟล์", ImageSource = "Profile.png", TargetType = typeof(ProfilePage) });
                        // frick just frick
                        menuList.Add(new MasterPageItem() { Title = "อีเมล์", ImageSource = "Email.png", TargetType = typeof(Email) });
                        menuList.Add(new MasterPageItem() { Title = "ไดเรกทอรีวิทยาเขต", ImageSource = "Campus.png", TargetType = typeof(CampusDirectory) });
                        menuList.Add(new MasterPageItem() { Title = "ข้อมูลอาจารย์", ImageSource = "Lecturer.png", TargetType = typeof(LecturerInfo) });

                        menuList.Add(new MasterPageItem() { Title = "ออกจากระบบ", ImageSource = "Exit.png", TargetType = typeof(LoginPage) });
                        // Setting our list to be ItemSource for ListView in MainPage.xaml
                        navigationDrawerList.ItemsSource = menuList;
                        // Initial navigation, this can be used for our home page
                        Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
                        break;
                    }
                case "vi":
                    {
                        menuList.Add(new MasterPageItem() { Title = "Trang Chủ", ImageSource = "Home.png", TargetType = typeof(HomePage) });
                        menuList.Add(new MasterPageItem() { Title = "Kết quả", ImageSource = "Result.png", TargetType = typeof(ResultPage) });
                        menuList.Add(new MasterPageItem() { Title = "Bảng điểm", ImageSource = "Transcript.png", TargetType = typeof(TransciptPage) });
                        menuList.Add(new MasterPageItem() { Title = "Thời gian biểu", ImageSource = "Calendar.png", TargetType = typeof(TimetablePage) });
                        menuList.Add(new MasterPageItem() { Title = "Hồ sơ", ImageSource = "Profile.png", TargetType = typeof(ProfilePage) });
                        // frick just frick
                        menuList.Add(new MasterPageItem() { Title = "E-mail", ImageSource = "Email.png", TargetType = typeof(Email) });
                        menuList.Add(new MasterPageItem() { Title = "Thư mục trường ", ImageSource = "Campus.png", TargetType = typeof(CampusDirectory) });
                        menuList.Add(new MasterPageItem() { Title = "Thông tin giảng viên ", ImageSource = "Lecturer.png", TargetType = typeof(LecturerInfo) });

                        menuList.Add(new MasterPageItem() { Title = "Đăng xuất", ImageSource = "Exit.png", TargetType = typeof(LoginPage) });
                        // Setting our list to be ItemSource for ListView in MainPage.xaml
                        navigationDrawerList.ItemsSource = menuList;
                        // Initial navigation, this can be used for our home page
                        Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
                        break;
                    }
                case "da":
                    {
                        menuList.Add(new MasterPageItem() { Title = "Hjem", ImageSource = "Home.png", TargetType = typeof(HomePage) });
                        menuList.Add(new MasterPageItem() { Title = "Resultat", ImageSource = "Result.png", TargetType = typeof(ResultPage) });
                        menuList.Add(new MasterPageItem() { Title = "Udskrift", ImageSource = "Transcript.png", TargetType = typeof(TransciptPage) });
                        menuList.Add(new MasterPageItem() { Title = "Tidsplan", ImageSource = "Calendar.png", TargetType = typeof(TimetablePage) });
                        menuList.Add(new MasterPageItem() { Title = "Profil", ImageSource = "Profile.png", TargetType = typeof(ProfilePage) });
                        // frick just frick
                        menuList.Add(new MasterPageItem() { Title = "E-mail", ImageSource = "Email.png", TargetType = typeof(Email) });
                        // erick please ask your mum about this :(
                        menuList.Add(new MasterPageItem() { Title = "Campus Directory", ImageSource = "Campus.png", TargetType = typeof(CampusDirectory) });
                        menuList.Add(new MasterPageItem() { Title = "Foredragsinformation ", ImageSource = "Lecturer.png", TargetType = typeof(LecturerInfo) });

                        menuList.Add(new MasterPageItem() { Title = "Log ud", ImageSource = "Exit.png", TargetType = typeof(LoginPage) });
                        // Setting our list to be ItemSource for ListView in MainPage.xaml
                        navigationDrawerList.ItemsSource = menuList;
                        // Initial navigation, this can be used for our home page
                        Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
                        break;
                    }
                case "id":
                    {
                        menuList.Add(new MasterPageItem() { Title = "Rumah", ImageSource = "Home.png", TargetType = typeof(HomePage) });
                        menuList.Add(new MasterPageItem() { Title = "Hasil", ImageSource = "Result.png", TargetType = typeof(ResultPage) });
                        menuList.Add(new MasterPageItem() { Title = "Udskrift", ImageSource = "Transcript.png", TargetType = typeof(TransciptPage) });
                        menuList.Add(new MasterPageItem() { Title = "Tabel Waktu", ImageSource = "Calendar.png", TargetType = typeof(TimetablePage) });
                        menuList.Add(new MasterPageItem() { Title = "Profil", ImageSource = "Profile.png", TargetType = typeof(ProfilePage) });
                        // frick just frick
                        menuList.Add(new MasterPageItem() { Title = "Surel", ImageSource = "Email.png", TargetType = typeof(Email) });
                        menuList.Add(new MasterPageItem() { Title = "Direktori Kampus ", ImageSource = "Campus.png", TargetType = typeof(CampusDirectory) });
                        menuList.Add(new MasterPageItem() { Title = "Informasi Dosen ", ImageSource = "Lecturer.png", TargetType = typeof(LecturerInfo) });

                        menuList.Add(new MasterPageItem() { Title = "Keluar", ImageSource = "Exit.png", TargetType = typeof(LoginPage) });
                        // Setting our list to be ItemSource for ListView in MainPage.xaml
                        navigationDrawerList.ItemsSource = menuList;
                        // Initial navigation, this can be used for our home page
                        Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
                        break;
                    }
                case "sr-Cyrl":
                    {
                        menuList.Add(new MasterPageItem() { Title = "Почетна страница", ImageSource = "Home.png", TargetType = typeof(HomePage) });
                        menuList.Add(new MasterPageItem() { Title = "Страница са резултатима", ImageSource = "Result.png", TargetType = typeof(ResultPage) });
                        menuList.Add(new MasterPageItem() { Title = "Трансцрипт Паге", ImageSource = "Transcript.png", TargetType = typeof(TransciptPage) });
                        menuList.Add(new MasterPageItem() { Title = "Распоред", ImageSource = "Calendar.png", TargetType = typeof(TimetablePage) });
                        menuList.Add(new MasterPageItem() { Title = "профил страница", ImageSource = "Profile.png", TargetType = typeof(ProfilePage) });
                        // frick just frick
                        menuList.Add(new MasterPageItem() { Title = "Емаил", ImageSource = "Email.png", TargetType = typeof(Email) });
                        menuList.Add(new MasterPageItem() { Title = "Цампус Дирецтори ", ImageSource = "Campus.png", TargetType = typeof(CampusDirectory) });
                        menuList.Add(new MasterPageItem() { Title = "Информације о предавачу", ImageSource = "Lecturer.png", TargetType = typeof(LecturerInfo) });

                        menuList.Add(new MasterPageItem() { Title = "Одјави се", ImageSource = "Exit.png", TargetType = typeof(LoginPage) });
                        // Setting our list to be ItemSource for ListView in MainPage.xaml
                        navigationDrawerList.ItemsSource = menuList;
                        // Initial navigation, this can be used for our home page
                        Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
                        break;
                    }
            }


            //        // Adding menu items to menuList and you can define title ,page and icon
            //menuList.Add(new MasterPageItem() { Title = "Home", ImageSource = "Home.png", TargetType = typeof(HomePage) });
            //menuList.Add(new MasterPageItem() { Title = "Result", ImageSource = "Result.png", TargetType = typeof(ResultPage) });
            //menuList.Add(new MasterPageItem() { Title = "Transcript", ImageSource = "Transcript.png", TargetType = typeof(TransciptPage) });
            //menuList.Add(new MasterPageItem() { Title = "Time Table", ImageSource = "Calendar.png", TargetType = typeof(TimetablePage) });
            //menuList.Add(new MasterPageItem() { Title = "Profile", ImageSource = "Profile.png", TargetType = typeof(ProfilePage) });
            //menuList.Add(new MasterPageItem() { Title = "Log Out", ImageSource = "Exit.png", TargetType = typeof(LoginPage) });
            //// Setting our list to be ItemSource for ListView in MainPage.xaml
            //navigationDrawerList.ItemsSource = menuList;
            //// Initial navigation, this can be used for our home page
            //Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
        }
        // Event for Menu Item selection, here we are going to handle navigation based
        // on user selection in menu ListView
         void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}