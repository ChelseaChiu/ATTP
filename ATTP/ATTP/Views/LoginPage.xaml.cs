using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATTP.Models;
using ATTP.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ATTP.Resources;

using Plugin.Multilingual;
using System.Globalization;
using System.Windows.Input;
using System.Diagnostics;

namespace ATTP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public ObservableCollection<Language> Languages { get; }
        = new ObservableCollection<Language>()
            {
                new Language { DisplayName =  "中文 - Chinese (simplified)", ShortName = "zh-Hans" },
                new Language { DisplayName =  "Chinese(Traditional)", ShortName = "zh-Hant" },
                new Language { DisplayName =  "English", ShortName = "en" },
                new Language { DisplayName =  "Монгол-Mongolian", ShortName = "mn-MN" },
                new Language { DisplayName =  "ไทย-Thai", ShortName = "th" },
                new Language { DisplayName =  "Melayu-Malay", ShortName = "ms" },
                new Language { DisplayName =  "Français - French", ShortName = "fr" },
                new Language { DisplayName =  "Deutsche - German", ShortName = "de" },
                new Language { DisplayName =  "日本語 - Japanese", ShortName = "ja" },
                new Language { DisplayName =  "한국어 - Korean", ShortName = "ko" },
                new Language { DisplayName =  "Русский - Russian", ShortName = "ru" }
            };
        public ICommand TapCommand => new Command<string>(OpenBrowser);
        public LoginPage()
        {


            InitializeComponent();


            App._Id = null;
            App._Username = null;
            //App._language = null;



            BindingContext = this;
            PickerLanguages.SelectedIndexChanged += PickerLanguages_SelectedIndexChanged;


            Init();


        }
        public void PickerLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var language = Languages[PickerLanguages.SelectedIndex];



            try
            {

                var culture = new CultureInfo(language.ShortName);
                App._language = language.ShortName;
                AppResources.Culture = culture;
                CrossMultilingual.Current.CurrentCultureInfo = culture;
            }
            catch (Exception)
            {
            }

            TranslationUsernameLabel.Text = AppResources.TranslationUsername;
            Entry_Username.Placeholder = AppResources.TranslationLogin;
            Entry_Password.Placeholder = AppResources.TranslationPassword;
            TranslationPasswordLabel.Text = AppResources.TranslationPassword;
            Btn_SignIn.Text = AppResources.TranslationSignIn;
            ForgetText.Text = AppResources.TranslationForgetText;
            ClickHereText.Text = AppResources.TranslationLoginPageClickerHere;
            languageLabel.Text = AppResources.TranslationSelectLanguage;
            LoginResetLabel.Text = AppResources.TranslationReset;


            //IdislikeLivingTranslation.Text = AppResources.String1;


        }
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            TranslationUsernameLabel.TextColor = Constants.MainTextColor;
            TranslationPasswordLabel.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginImageIcon.HeightRequest = Constants.LoginImageIconHeight;
            PickerLanguages.SelectedIndex = 2;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s, e);

        }

        public void SignInProcedure(object sender, EventArgs e)
        {

            var language = Languages[PickerLanguages.SelectedIndex];


            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.Valdation(user.Id,user.Password))
            {
                App._Id = user.Id;
                StudentServiceRef.Student student = Proxy.getStudentById(user.Id);
                App._Username = $"{student.FirstName} {student.LastName}";
                switch (language.ShortName)
                {
                    // Im aware this is the lazy method that requires alot more work but im tired and lazy rn Kimi

                    case "zh-Hans":
                        {
                            DisplayAlert("登录", "登录成功", "好");
                            break;
                        }
                    case "zh-Hant":
                        {
                            DisplayAlert("登錄", "登錄成功", "好");
                            break;
                        }
                    case "en":
                        {
                            DisplayAlert("Login", "Login Success", "OK");
                            break;
                        }
                    case "mn-MN":
                        {
                            DisplayAlert("Нэвтрэх", "Нэвтрэх амжилт", "за юу");
                            break;
                        }
                    case "fr":
                        {
                            DisplayAlert("S'identifier", "Connexion réussie", "d'accord");
                            break;
                        }

                    case "ms":
                        {
                            DisplayAlert("Log masuk", "Masuk Kejayaan", "baik");
                            break;
                        }

                    case "th":
                        {
                            DisplayAlert("เข้าสู่ระบบ", "เข้าสู่ระบบสำเร็จ", "ถูก");
                            break;
                        }

                    case "de":
                        {
                            DisplayAlert("Login", "Erfolgreich eingeloggt", "in Ordnung");
                            break;
                        }
                    case "ja":
                        {
                            DisplayAlert("ログインする", "ログイン成功", "はい");
                            break;
                        }
                    case "ko":
                        {
                            DisplayAlert("로그인", "로그인 성공", "괜찮아");
                            break;
                        }
                    case "ru":
                        {
                            DisplayAlert("Авторизоваться", "Войти успешно", "Хорошо");
                            break;
                        }
                        //App.UserDatabase.SaveUser(user);


                }


                // Debug.WriteLine(App._Id);
                Navigation.PushModalAsync(new MainPage());





            }
            else
            {
                switch (language.ShortName)
                {
                    // Im aware this is the lazy method that requires alot more work but im tired and lazy rn Kimi

                    case "zh-Hans":
                        {
                            DisplayAlert("登录", "登录不正确 错误：空的用户名或密码", "好");
                            break;
                        }
                    case "zh-Hant":
                        {
                            DisplayAlert("登錄", "登錄不正確 錯誤：空的用戶名或密碼", "好");
                            break;
                        }
                    case "en":
                        {
                            DisplayAlert("Login", "Login Not Correct Error:empty username or password", "OK");
                            break;
                        }
                    case "mn-MN":
                        {
                            DisplayAlert("Нэвтрэх", "Нэвтрэх буруу байна Алдаа: хоосон хэрэглэгчийн нэр эсвэл нууц үг", "за юу");
                            break;
                        }
                    case "fr":
                        {
                            DisplayAlert("S'identifier", "Login non correct Erreur: nom d'utilisateur ou mot de passe vide", "d'accord");
                            break;
                        }
                    case "de":
                        {
                            DisplayAlert("Login", "Login nicht korrekt Fehler: leerer Benutzername oder Passwort", "in Ordnung");
                            break;
                        }
                    case "ja":
                        {
                            DisplayAlert("ログインする", "ログインが正しくありません エラー：空のユーザー名またはパスワード", "はい");
                            break;
                        }
                    case "ko":
                        {
                            DisplayAlert("로그인", "로그인이 올바르지 않습니다 오류 : 빈 사용자 이름 또는 비밀번호", "괜찮아");
                            break;
                        }
                    case "ru":
                        {
                            DisplayAlert("Авторизоваться", "Войти успешно Ошибка: пустое имя пользователя или пароль", "Хорошо");
                            break;
                        }

                    case "ms":
                        {
                            DisplayAlert("Log masuk", "Masuk Kejayaan Ralat: nama pengguna atau kata laluan kosong", "baik");
                            break;
                        }

                    case "th":
                        {
                            DisplayAlert("เข้าสู่ระบบ", "เข้าสู่ระบบไม่ถูกต้อง ข้อผิดพลาด: ชื่อผู้ใช้หรือรหัสผ่านว่างเปล่า ", "ตกลง");
                            break;
                        }

                }
            }
            


        }
        void OpenBrowser(string url)
        {
            Device.OpenUri(new Uri(url));
        }
    }
}
