using System;
using System.IO;
using System.Net;
using System.Threading;

namespace ArduinoSerialRepeater
{
    public class WebServer
    {
        private string context;
        private HttpListener httpListener = new HttpListener();
        private Thread httpListenerThread;

        public delegate void IOnWebServerConnected(HttpListenerRequest req, HttpListenerResponse res);
        public event IOnWebServerConnected OnWebServerConnectedEvent;

        public bool IsListening() 
        {
            return httpListener.IsListening;
        }

        public WebServer(string context)
        {
            this.context = context;
        }

        public void Start()
        {
            try
            {
                httpListener.Prefixes.Add(context);
                httpListener.Start();
                httpListenerThread = new Thread(httpListenerThreadFx);
                httpListenerThread.Start(httpListener);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Stop()
        {
            try
            {
                if (httpListener.IsListening)
                {
                    httpListener.Stop();
                    httpListenerThread.Join();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void httpListenerThreadFx(object httpListenerObject)
        {
            HttpListener httpListener = (HttpListener)httpListenerObject;
            while (httpListener.IsListening)
            {
                Stream output = null;
                try
                {
                    HttpListenerContext context = httpListener.GetContext();
                    HttpListenerRequest request = context.Request;
                    HttpListenerResponse response = context.Response;
                    if (OnWebServerConnectedEvent != null)
                    {
                        OnWebServerConnectedEvent.Invoke(request, response);
                    }
                }
                catch
                {
                    /* NOP */
                }
                finally
                {
                    if (output != null)
                    {
                        output.Close();
                    }
                }
            }
        }
        ~WebServer()
        {
            Stop();
        }
    }
}
