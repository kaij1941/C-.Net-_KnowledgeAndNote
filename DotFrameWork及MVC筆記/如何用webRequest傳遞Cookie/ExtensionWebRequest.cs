   /// <summary>
    /// 擴充webRequest方法
    /// </summary>
    public static class ExtensionForWebRequest
    {
        /// <summary>
        /// 增加裝載cookie
        /// </summary>
        /// <param name="webRequest"></param>
        /// <param name="cookie">Type:Cookie</param>
        /// <returns></returns>
        public static bool AddCookie(this WebRequest webRequest, Cookie cookie)
        {
            HttpWebRequest httpRequest = webRequest as HttpWebRequest;
            if (httpRequest == null)
            {
                return false;
            }

            if (httpRequest.CookieContainer == null)
            {
                httpRequest.CookieContainer = new CookieContainer();
            }

            httpRequest.CookieContainer.Add(cookie);
            return true;
        }

        /// <summary>
        /// 增加裝載cookie
        /// </summary>
        /// <param name="webRequest"></param>
        /// <param name="cookie">Type:HttpCookie</param>
        /// <returns></returns>
        public static bool AddCookie(this WebRequest webRequest, HttpCookie cookie)
        {
            HttpWebRequest httpRequest = webRequest as HttpWebRequest;
            if (httpRequest == null)
            {
                return false;
            }

            if (httpRequest.CookieContainer == null)
            {
                httpRequest.CookieContainer = new CookieContainer();
            }
       
            var oC = new Cookie
            {
                Domain = webRequest.RequestUri.Host,
                Expires = cookie.Expires,
                Name = cookie.Name,
                Path = cookie.Path,
                Secure = cookie.Secure,
                Value = cookie.Value
            };

            httpRequest.CookieContainer.Add(oC);
            return true;
        }

    }
