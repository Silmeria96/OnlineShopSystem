using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopSystem.UI.Controllers
{
    /// <summary>
    /// 文件上传控制器
    /// </summary>
    public class FileUploadController : Controller
    {
        /// <summary>
        /// 上传图片
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        [HttpPost]
        public JObject UploadImage(HttpPostedFileBase img)
        {
            JObject result = new JObject();

            if (img == null)
            {
                result["flag"] = false;
                result["msg"] = "请先选择要上传的图片！";
                return result;
            }

            var fileName = img.FileName;
            var filePath = Server.MapPath("~/Upload/Images/");
            var fileViewPath = Url.Content(string.Format("~/Upload/Images/{0}", fileName));

            try
            {
                img.SaveAs(Path.Combine(filePath,fileName));
                result["flag"] = true;
                result["msg"] = "上传成功！";
                result["path"] = fileViewPath;
            }
            catch
            {
                result["flag"] = false;
                result["msg"] = "上传失败！";
            }

            return result;
        }


    }
}