using cloudscribe.SimpleContent.Models;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace esdm.ContentTemplates.Services
{
    public class ContentTemplateProvider : IContentTemplateProvider
    {
        public ContentTemplateProvider(IStringLocalizer<SharedTemplateResources> stringLocalizer)
        {
            _sr = stringLocalizer;
        }

        private IStringLocalizer _sr;
        private List<ContentTemplate> _list = null;

        public Task<List<ContentTemplate>> GetAllTemplates()
        {
            if (_list == null)
            {
                BuildList();
            }

            return Task.FromResult(_list);
        }

        private void BuildList()
        {
            if (_list != null) { return; }

            _list = new List<cloudscribe.SimpleContent.Models.ContentTemplate>();
            _list.Add(BuildInlineScriptTemplate());
        }


        private ContentTemplate BuildInlineScriptTemplate()
        {
            var template = new ContentTemplate()
            {
                Key = "esdm-inline-script-template",
                Title = _sr["Content with Inline Javascript"],
                Description = _sr["Useful if you need to directly edit some inline script instead of or in addition to adding external scripts."],
                EditView = "ContentTemplates/InlineScriptEdit",
                RenderView = "ContentTemplates/InlineScriptRender",
                ModelType = "esdm.ContentTemplates.ViewModels.InlineScriptViewModel, esdm.ContentTemplates.Bootstrap4",
                ScreenshotUrl = "",
                ProjectId = "*",
                AvailbleForFeature = "Page",
                Enabled = true,
                FormParserName = "DefaultModelFormParser",
                SerializerName = "Json",
                ValidatorName = "DefaultTemplateModelValidator",
                GroupSort1 = "555556",
                GroupSort2 = "555800",

                EditCss = new List<CssFile>()
                {

                },
                EditScripts = new List<ScriptFile>()
                {
                    //new ScriptFile()
                    //{
                    //    Url = "/cr/js/jquery.unobtrusive-ajax.min.js",
                    //    Environment = "any",
                    //    Sort = 1
                    //},
                    //new ScriptFile()
                    //{
                    //    Url = "/cr/js/cloudscribe-modaldialog-bootstrap4.min.js",
                    //    Environment = "any",
                    //    Sort = 2
                    //}
                    
                },

                RenderCss = new List<CssFile>()
                {

                },
                RenderScripts = new List<ScriptFile>()
                {
                    //new ScriptFile()
                    //{
                    //    Url = "/forms/js/es6-shim.min.js",
                    //    Environment = "any",
                    //    Sort = 1
                    //},
                    
                }

            };

            return template;

        }

    }
}
