#pragma checksum "C:\Users\Mekansal Bulut\Desktop\case\CaseProject\Web\Views\Articles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c27afbecb3244d996496ff806b4ac9997b705cf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_Index), @"mvc.1.0.view", @"/Views/Articles/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Mekansal Bulut\Desktop\case\CaseProject\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mekansal Bulut\Desktop\case\CaseProject\Web\Views\_ViewImports.cshtml"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mekansal Bulut\Desktop\case\CaseProject\Web\Views\_ViewImports.cshtml"
using Model.DtoModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mekansal Bulut\Desktop\case\CaseProject\Web\Views\_ViewImports.cshtml"
using Model.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c27afbecb3244d996496ff806b4ac9997b705cf4", @"/Views/Articles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a86823306d1de1d2fc60fadcd67335ff3130f8ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Articles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/Template/MaterialTemp/vendors/fileinput/fileinput.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-for", new global::Microsoft.AspNetCore.Html.HtmlString("item in categoryList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-bind:value", new global::Microsoft.AspNetCore.Html.HtmlString("item.id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("articlesUpdate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c27afbecb3244d996496ff806b4ac9997b705cf45297", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style>
    th {
        font-weight: bold !important;
    }
</style>

<div class=""col-sm-12"" id=""articlesList"">
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"" data-backdrop=""false"">
        
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
               
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Güncelle</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>

                <div class=""modal-body"">
                    <div class=""alert alert-success alert-dismissible"" role=""alert"" v-if=""state.condition == true"">
                        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true""");
            WriteLiteral(@">×</span></button>
                        {{state.message}}
                    </div>

                    <div class=""alert alert-danger alert-dismissible"" role=""alert"" v-if=""state.condition== false"">
                        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true"">×</span></button>
                        Oh snap! Change a few things up and try submitting again.
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c27afbecb3244d996496ff806b4ac9997b705cf47947", async() => {
                WriteLiteral(@"
                        <div class=""fileinput fileinput-new"" data-provides=""fileinput"">
                            <div class=""fileinput-preview thumbnail"" data-trigger=""fileinput"">
                                <img v-bind:src=""guncellenecekData.path"" name=""fileImage"" />
                            </div>
                            <div>
                                <span class=""btn btn-success btn-file"">
                                    <span class=""fileinput-new"">Kapak</span>
                                    <span class=""fileinput-exists"">Değiştir</span>
                                    <input type=""file"" id=""raster-import-file"" name=""fileImage"">
                                </span>
                                <a href=""#"" class=""btn btn-danger fileinput-exists"" data-dismiss=""fileinput"">Kaldır</a>
                            </div>
                        </div>
                        <input type=""hidden"" id=""custId"" name=""id"" v-model=""guncellenecekData.id"">
         ");
                WriteLiteral(@"               <input type=""hidden"" name=""path"" v-model=""guncellenecekData.path"">

                        <div class=""input-group"">
                            <span class=""input-group-addon""><i class=""zmdi zmdi-layers""></i></span>
                            <div class=""fg-line"">
                                <select class=""form-control"" v-model=""guncellenecekData.kategoriId"" name=""kategoriId"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c27afbecb3244d996496ff806b4ac9997b705cf49764", async() => {
                    WriteLiteral("Kategori Seçiniz");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c27afbecb3244d996496ff806b4ac9997b705cf410824", async() => {
                    WriteLiteral("{{item.ad}}");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </select>
                            </div>
                        </div>

                        <div class=""input-group mt-3"">
                            <span class=""input-group-addon""><i class=""zmdi zmdi-layers""></i></span>
                            <div class=""fg-line"">
                                <input type=""text"" class=""form-control"" placeholder=""Başlık"" name=""title"" v-model=""guncellenecekData.title"">
                            </div>
                        </div>

                        <div class=""input-group mt-3"">
                            <span class=""input-group-addon""><i class=""zmdi zmdi-collection-text""></i></span>
                            <div class=""fg-line"">
                                <textarea class=""form-control"" rows=""4"" placeholder=""Metin"" name=""text"" v-model=""guncellenecekData.text""></textarea>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Kapat</button>
                    <button type=""button"" class=""btn btn-primary"" v-on:click=""editArticlesEnd()"">Değişiklikleri Kaydet</button>
                </div>
            </div>
        </div>
    </div>


    <div class=""card"">
        <div class=""card-header ch-alt m-b-20"">
            <h2>Yazı İşlemleri <small>Yazı Listesi</small></h2>


            <a href=""/Articles/Ekle"" class=""btn bgm-green btn-float waves-effect""><i class=""zmdi zmdi-plus""></i></a>
        </div>

        <div class=""card-body card-padding"">
            <div role=""tabpanel"">
                <div class=""card"">
                    <div class=""card-header"">
");
            WriteLiteral(@"                    </div>

                    <div class=""table-responsive"">
                        <table class=""table table-striped"">
                            <thead>
                                <tr>
                                    <th>Kapak</th>
                                    <th>Başlık</th>
                                    <th>Metin</th>
                                    <th>İşlemler</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr v-for=""item in list"" v-bind:id=""'silButon-'+ item.id"">
                                    <td> <img v-bind:src=""item.path"" style=""height:50px;object-fit:contain;"" /></td>
                                    <td>{{item.title}}</td>
                                    <td><span style=""display:block;text-overflow: ellipsis;width: 200px;overflow: hidden; white-space: nowrap;"">{{item.text}}</span></td>
                                    <t");
            WriteLiteral(@"d class=""text-left"">
                                        <a class=""btn btn-icon command-edit waves-effect waves-circle"" data-toggle=""modal"" data-target=""#exampleModal"" v-on:click=""editArticlesStart(item.id)""><span class=""zmdi zmdi-edit""></span></a>
                                        <button class=""btn btn-icon command-delete waves-effect waves-circle""><span class=""zmdi zmdi-delete"" v-on:click=""articlesDelete(item.id)""></span></button>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>




            </div>


        </div>
    </div>
</div>


<script type=""text/javascript"">
    new Vue({
        el: ""#articlesList"",
        data: {
            list: """",
            state: {
                condition: null,
                message: """"
            },
            guncellenecekData: {
                title: """",
              ");
            WriteLiteral(@"  text: """",
                path: """",
                id: null,
                kategoriId: null
            },
            categoryList: """"

        },
        beforeCreate() {
            if (!localStorage.getItem(""localToken"")) {
                window.location.href = ""/login/index"";
            }
        },
        beforeMount() {
            this.getAllList()
        },
        methods: {
            getAllList() {
                $.ajax({
                    dataType: 'json',
                    type: 'POST',
                    contentType: 'application/json',
                    url: 'http://localhost:1917/api/Articles/ListAll',
                    success: (res, status) => {
                        this.list = res;
                    },
                    error: function (res, status) {
                        console.error(""Hata"")
                    },
                })

            },
            articlesDelete(id) {
                Swal.fire({
                ");
            WriteLiteral(@"    title: 'Silmek İstediğinize Emin Misiniz?',
                    icon: 'warning',
                    showCancelButton: true,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#d33',
                    confirmButtonText: 'Evet, eminim!'
                }).then((result) => {
                    if (result.isConfirmed) {
                        $.ajax({
                            type: 'POST',
                            headers: {
                                'Authorization': 'bearer ' + localStorage.getItem(""localToken"")
                            },
                            url: 'http://localhost:1917/api/Articles/SoftDelete/' + id.toString(),
                            success: (res, status) => {
                                this.list = this.list.filter(x => x.id != id);
                            },
                            error: function (res, status) {
                                console.error(""Hata"")
                   ");
            WriteLiteral(@"         },
                        })
                        Swal.fire(
                            'Silindi!',
                            'İşleminiz Başarıyla Gerçekleştirildi.',
                            'success'
                        )
                    }
                })
            },
            editArticlesStart(id) {
                $.ajax({
                    dataType: 'json',
                    type: 'POST',
                    contentType: 'application/json',
                    url: 'http://localhost:1917/api/Articles/Get/' + id.toString(),
                    success: (res, status) => {
                        this.guncellenecekData.title = res.title;
                        this.guncellenecekData.text = res.text;
                        this.guncellenecekData.path = res.path;
                        this.guncellenecekData.id = res.id;
                        this.guncellenecekData.kategoriId = res.kategoriId;
                        this.kategoriList();
     ");
            WriteLiteral(@"               },
                    error: function (res, status) {
                        console.error(""Hata"")
                    },
                })
            },
            editArticlesEnd() {
                var form = $('#articlesUpdate')[0];
                var data = new FormData(form);
                $.ajax({
                    dataType: 'json',
                    type: 'POST',
                    headers: {
                        'Authorization': 'bearer ' + localStorage.getItem(""localToken"")
                    },
                    data: data,
                    processData: false,
                    contentType: false,
                    url: 'http://localhost:1917/api/Articles/Update',
                    success: (res, status) => {
                        this.getAllList()
                        this.state.condition = true;
                        this.state.message = ""Güncelleme İşlemi Başarılı"";
                        setTimeout(() => { this.state.cond");
            WriteLiteral(@"ition = null; }, 1000);
                    },
                    error: (res, status) => {
                        this.getAllList()
                        this.state.condition = true;
                        this.state.message = ""Güncelleme İşlemi Başarılı"";
                        setTimeout(() => { this.state.condition = null; }, 1000);
                    },
                })

            },
            kategoriList() {
                $.ajax({
                    dataType: 'json',
                    type: 'POST',
                    contentType: 'application/json',
                    url: 'http://localhost:1917/api/Category/ListAll',
                    success: (res, status) => {
                        this.categoryList = res
                    },
                    error: function (res, status) {

                    },
                })

            },
            
        }
    })
</script>



");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
