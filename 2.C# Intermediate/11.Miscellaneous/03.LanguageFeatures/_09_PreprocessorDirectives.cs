#define underDev

//Disable all warnings!
#pragma warning disable
namespace _11.Miscellaneous._03.LanguageFeatures
{
    class _11_PreprocessorDirectives
    {
        #region myMainMwthod
        void ThisIsMain()
        {


#if(underDev)
            Console.WriteLine("This app is under development");
#else
            Console.WriteLine("This app is complete");
#warning This app is not complete
#error This is an error!

#endif
        }
#endregion
    }
}
