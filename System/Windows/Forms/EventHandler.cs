namespace System.Windows.Forms
{
    internal class EventHandler
    {
        private WebBrowser webBrowser2;

        public EventHandler(WebBrowser webBrowser2)
        {
            this.webBrowser2 = webBrowser2;
        }

        public static implicit operator WebBrowser(EventHandler v)
        {
            throw new NotImplementedException();
        }
    }
}