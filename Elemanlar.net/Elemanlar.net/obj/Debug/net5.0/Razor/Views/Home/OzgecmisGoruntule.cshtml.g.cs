#pragma checksum "C:\Users\Burak Erdem\source\repos\Elemanlar.net\Elemanlar.net\Views\Home\OzgecmisGoruntule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fcaede20927b647de9e0443d71fc2150da0ac4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OzgecmisGoruntule), @"mvc.1.0.view", @"/Views/Home/OzgecmisGoruntule.cshtml")]
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
#line 1 "C:\Users\Burak Erdem\source\repos\Elemanlar.net\Elemanlar.net\Views\_ViewImports.cshtml"
using Elemanlar.net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Burak Erdem\source\repos\Elemanlar.net\Elemanlar.net\Views\_ViewImports.cshtml"
using Elemanlar.net.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fcaede20927b647de9e0443d71fc2150da0ac4c", @"/Views/Home/OzgecmisGoruntule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cedde627395080717b91836ac239438171eae304", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OzgecmisGoruntule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.OzgecmisViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Burak Erdem\source\repos\Elemanlar.net\Elemanlar.net\Views\Home\OzgecmisGoruntule.cshtml"
  
    ViewData["Title"] = "OzgecmisGoruntule";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""content"">
    <div class=""container-fluid"">

        <div class=""row"">
            <div class=""col-md-12"">

                <!-- Profile Image -->
                <div class=""card card-red card-outline"">
                    <div class=""card-body box-profile"">
                        <div class=""text-center"">
                            <img id=""personelIMG"" class=""profile-user-img img-fluid"" style=""height:200px;width:240px;""");
            BeginWriteAttribute("src", " src=\"", 594, "\"", 622, 1);
#nullable restore
#line 17 "C:\Users\Burak Erdem\source\repos\Elemanlar.net\Elemanlar.net\Views\Home\OzgecmisGoruntule.cshtml"
WriteAttributeValue("", 600, Model.ProfilFotografi, 600, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"User profile picture\">\r\n                        </div>\r\n\r\n                        <h3 class=\"profile-username text-center mt-3\" id=\"txtname\">");
#nullable restore
#line 20 "C:\Users\Burak Erdem\source\repos\Elemanlar.net\Elemanlar.net\Views\Home\OzgecmisGoruntule.cshtml"
                                                                              Write(Model.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp; ");
#nullable restore
#line 20 "C:\Users\Burak Erdem\source\repos\Elemanlar.net\Elemanlar.net\Views\Home\OzgecmisGoruntule.cshtml"
                                                                                               Write(Model.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                        <p class=\"text-muted text-center\" id=\"txIsTanimi\"></p>\r\n\r\n                        <ul class=\"list-group list-group-unbordered mb-3\">\r\n");
            WriteLiteral(@"                            <li class=""list-group-item"">
                                <div class=""form-group"">
                                    <div class=""row"">
                                        <div class=""col-md-3"">
                                            <div class=""input-group input-group-sm"">
                                                <div class=""input-group-prepend"">
                                                    <span><i class=""fa fa-calendar""></i></span>
                                                </div>
                                                <label for=""exampleInputLokasyon"">&nbsp;Yaş</label>
                                            </div>
                                            <a>");
#nullable restore
#line 38 "C:\Users\Burak Erdem\source\repos\Elemanlar.net\Elemanlar.net\Views\Home\OzgecmisGoruntule.cshtml"
                                          Write(Model.Yas);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                        </div>
                                        <div class=""col-md-3"">
                                            <div class=""input-group input-group-sm"">
                                                <div class=""input-group-prepend"">
                                                    <span><i class=""fa fa-transgender""></i></span>
                                                </div>
                                                <label for=""exampleInputLokasyon"">&nbsp; Cinsiyet</label>
                                            </div>
                                            <p>");
#nullable restore
#line 47 "C:\Users\Burak Erdem\source\repos\Elemanlar.net\Elemanlar.net\Views\Home\OzgecmisGoruntule.cshtml"
                                          Write(Model.Cinsiyet);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>
                                        <div class=""col-md-3"">
                                            <div class=""input-group input-group-sm"">
                                                <div class=""input-group-prepend"">
                                                    <span><i class=""fa fa-transgender""></i></span>
                                                </div>
                                                <label for=""exampleInputLokasyon"">&nbsp; Unvan</label>
                                            </div>
                                            <p>");
#nullable restore
#line 56 "C:\Users\Burak Erdem\source\repos\Elemanlar.net\Elemanlar.net\Views\Home\OzgecmisGoruntule.cshtml"
                                          Write(Model.Unvan);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>
                                        <div class=""col-md-3"">
                                            <div class=""input-group input-group-sm"">
                                                <div class=""input-group-prepend"">
                                                    <span><i class=""fa fa-transgender""></i></span>
                                                </div>
                                                <label for=""exampleInputLokasyon"">&nbsp; Ehliyet</label>
                                            </div>
                                            <p>");
#nullable restore
#line 65 "C:\Users\Burak Erdem\source\repos\Elemanlar.net\Elemanlar.net\Views\Home\OzgecmisGoruntule.cshtml"
                                          Write(Model.Ehliyet);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>
                                    </div>
                                </div>
                            </li>

                            <li class=""list-group-item"">
                                <div class=""form-group"">
                                    <div class=""row"">
                                        <div class=""col-md-3"">
                                            <div class=""input-group input-group-sm"">
                                                <div class=""input-group-prepend"">
                                                    <span><i class=""fa fa-calendar""></i></span>
                                                </div>
                                                <label for=""exampleInputLokasyon"">&nbsp;Şehir</label>
                                            </div>
                                            <a>");
#nullable restore
#line 81 "C:\Users\Burak Erdem\source\repos\Elemanlar.net\Elemanlar.net\Views\Home\OzgecmisGoruntule.cshtml"
                                          Write(Model.Sehir);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                        </div>
                                        <div class=""col-md-3"">
                                            <div class=""input-group input-group-sm"">
                                                <div class=""input-group-prepend"">
                                                    <span><i class=""fa fa-transgender""></i></span>
                                                </div>
                                                <label for=""exampleInputLokasyon"">&nbsp; İlçe</label>
                                            </div>
                                            <p>");
#nullable restore
#line 90 "C:\Users\Burak Erdem\source\repos\Elemanlar.net\Elemanlar.net\Views\Home\OzgecmisGoruntule.cshtml"
                                          Write(Model.Ilce);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>
                                        <div class=""col-md-3"">
                                            <div class=""input-group input-group-sm"">
                                                <div class=""input-group-prepend"">
                                                    <span><i class=""fa fa-transgender""></i></span>
                                                </div>
                                                <label for=""exampleInputLokasyon"">&nbsp; Telefon</label>
                                            </div>
                                            <p>");
#nullable restore
#line 99 "C:\Users\Burak Erdem\source\repos\Elemanlar.net\Elemanlar.net\Views\Home\OzgecmisGoruntule.cshtml"
                                          Write(Model.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>
                                        <div class=""col-md-3"">
                                            <div class=""input-group input-group-sm"">
                                                <div class=""input-group-prepend"">
                                                    <span><i class=""fa fa-transgender""></i></span>
                                                </div>
                                                <label for=""exampleInputLokasyon"">&nbsp; Eposta</label>
                                            </div>
                                            <p>");
#nullable restore
#line 108 "C:\Users\Burak Erdem\source\repos\Elemanlar.net\Elemanlar.net\Views\Home\OzgecmisGoruntule.cshtml"
                                          Write(Model.Eposta);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li class=""list-group-item"">
                                <div class=""form-group"">
                                    <div class=""input-group input-group-sm"">
                                        <div class=""input-group-prepend"">
                                            <span><i class=""fa fa-industry""></i></span>
                                        </div>
                                        <label for=""exampleInputLokasyon"">&nbsp;Lokasyon</label>
                                    </div>
                                    <p ");
#nullable restore
#line 121 "C:\Users\Burak Erdem\source\repos\Elemanlar.net\Elemanlar.net\Views\Home\OzgecmisGoruntule.cshtml"
                                  Write(Model.Ilce);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                            </li>

                            <li class=""list-group-item"">
                                <div class=""form-group"">
                                    <div class=""input-group input-group-sm"">
                                        <div class=""input-group-prepend"">
                                            <span><i class=""fas fa-building""></i></span>
                                        </div>
                                        <label for=""exampleInputLokasyon"">&nbsp;Meslek</label>
                                    </div>
                                    <p id=""lblDepartman"">");
#nullable restore
#line 133 "C:\Users\Burak Erdem\source\repos\Elemanlar.net\Elemanlar.net\Views\Home\OzgecmisGoruntule.cshtml"
                                                    Write(Model.Unvan);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                            </li>
                            <li class=""list-group-item"">
                                <div class=""form-group"">
                                    <div class=""input-group input-group-sm"">
                                        <div class=""input-group-prepend"">
                                            <span><i class=""fas fa-building""></i></span>
                                        </div>
                                        <label for=""exampleInputLokasyon"">&nbsp;Maaş Beklentisi</label>
                                    </div>
                                    <p id=""lblDepartman"">");
#nullable restore
#line 144 "C:\Users\Burak Erdem\source\repos\Elemanlar.net\Elemanlar.net\Views\Home\OzgecmisGoruntule.cshtml"
                                                    Write(Model.MaasBeklentisi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                            </li>
                            <li class=""list-group-item"">
                                <div class=""row"">
                                    <div class=""col-sm-6 col-md-6 col-lg-6"">
                                        <button onclick=""personellistesiyonlendir()"" class=""btn btn-block btn-sm btn-coral"">&nbsp;Personel Listesi</button>
                                    </div>
                                    <div class=""col-sm-6 col-md-6 col-lg-6"">
                                        <button type=""button"" class=""btn btn-block btn-sm"" id=""btnMuayene"" style=""color:white; background-color:darkorchid"" data-toggle=""modal"" data-target=""#modal""><i class=""fas fa-briefcase-medical""></i>&nbsp;Muayene</button>
                                    </div>
                                </div>
                            </li>

                        </ul>
");
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n            <!-- /.col -->\r\n");
            WriteLiteral(@"    </div>
</div>
</section>
<div class=""modal"" id=""modal"" style=""display: none;"" aria-hidden=""true"">

    <div class=""modal-dialog modal-md"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Muayeneler</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-sm-3 col-md-3 col-lg-3"">
                        <button class=""btn btn-sm btn-info "" onclick=""PeriyodikYonlendirme(Id)"" title=""Periyodik Muayene"" id=""btnperiyodik""><i class=""fas fa-file-medical"" aria-hidden=""true""></i>&nbsp;Periyodik Muayene</button>
                    </div>
                    <div class=""col-sm-3 col-md-3 col-lg-3"">
                        <button class=""btn btn-sm btn-success"" onclick=""IseGirisYonlendirme(");
            WriteLiteral(@"Id)"" title=""İşe Giriş Muayene"" id=""btnisegiris""><i class=""fas fa-file-medical"" aria-hidden=""true""></i>&nbsp;İşe Giriş Muayene</button>
                    </div>

                    <div class=""col-sm-3 col-md-3 col-lg-3"">
                        <button class=""btn btn-sm btn-warning "" onclick="" PoliklinikYonlendirme(Id)"" title=""Poliklinik Muayene"" id=""btnpoliklinik""><i class=""fas fa-file-medical"" aria-hidden=""true""></i>&nbsp;Poliklinik Muayene</button>
                    </div>
                    <div class=""col-sm-3 col-md-3 col-lg-3"">
                        <button class=""btn btn-sm btn-danger"" onclick=""GebeYonlendirme(Id)"" title=""Gebe İzlem"" id=""btngebe"" style=""display:none""><i class=""fas fa-baby"" aria-hidden=""true""></i>&nbsp;Gebe İzlem</button>
                    </div>
                </div>
            </div>
            <div class=""modal-footer justify-content-between"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Kapat</button>
            </div");
            WriteLiteral(@">
        </div>
    </div>
</div>
<script>
    function SayfaDoldur() {
        $.ajax({
            type: ""GET"",
            url: ""/Home/OzgecmisGetir"",
            dataType: ""json"",
            async: false,
            data: null,
            success: function (result) {

                empData = data;
                LocationId = data.empVmodel.LocationId;

                if (data.empmodel.MedyaURL != null) {
                    $(""#personelIMG"").attr(""src"", data.empmodel.MedyaURL);
                }
                else {
                    $(""#personelIMG"").attr(""src"", ""/Content/profil.png"");
                }

                $(""#txtname"").html(data.empVmodel.FullName);
                $(""#txIsTanimi"").html(data.empVmodel.JobDescription);

                if (data.empVmodel.Gender == 'E') {
                    $(""#lblCinsiyet"").html(""Erkek"");
                }
                else if (data.empVmodel.Gender == 'K') {
                    $(""#lblCinsiyet"").html(""Kadın"");");
            WriteLiteral(@"
                }

                $(""#txtYas"").html(data.empmodel.Age);
                $(""#lblDepartman"").html(data.empVmodel.Department);
                $(""#lblLokasyon"").html(data.empmodel.LocationName);
                $(""#txtTCKNo"").val(data.empVmodel.TCKNo);
                $(""#txtSicilNo"").val(data.empVmodel.RegistryNumber);
                $(""#txtAd"").val(data.empVmodel.FirstName);
                $(""#txtSoyad"").val(data.empVmodel.LastName);
                if (data.empVmodel.Gender == 'E') {
                    $(""#txtCinsiyet"").val(""Erkek"");
                }
                else if (data.empVmodel.Gender == 'K') {
                    $(""#txtCinsiyet"").val(""Kadın"");
                }
                $(""#txtDogumTarihi"").val(CsharpDateToStringDateyyyymmdd(data.empVmodel.BirthDate));
                $(""#txtEgitimDurumu"").val(data.empVmodel.Education);
                $(""#txtDogumYeri"").val(data.empVmodel.BirthPlace);
                $(""#txtMedeniHal"").val(data.empVmodel.MartialSt");
            WriteLiteral(@"atus);
                $(""#txtCocukSayisi"").val(data.empVmodel.Childrens);

                for (var i = 0; i < data.riskGroups.length; i++) {
                    $(""#drdRiskGrubu"").find(""option[value='"" + data.riskGroups[i].RiskGroupId + ""']"").prop('selected', true).change();

                }

                $(""#txtIseGiris"").val(CsharpDateToStringDateyyyymmdd(data.empVmodel.JobStartDate));
                $(""#txtGecerliGorevBaslangic"").val(CsharpDateToStringDateyyyymmdd(data.empVmodel.JobStartDate));
                $(""#txtGorev"").val(data.empVmodel.JobTitle);
                $(""#txtDepartman"").val(data.empVmodel.Department);
                $(""#txtLokasyon"").val(data.empVmodel.Department);
                $(""#txtYaptigiIs"").val(data.empVmodel.JobDescription);
                $(""#txtKanGrubu"").val(data.empVmodel.BloodType);
                $(""#txtSigara"").val(data.SigaraDurum);
                $(""#txtAlkol"").val(data.AlkolDurum);
                $(""#txtAsi"").val(data.asilar);

        ");
            WriteLiteral(@"        $(""#txtAdres"").val(data.empVmodel.HomeAddress);
                $(""#txtEposta"").val(data.empVmodel.Email);
                $(""#txtTelefon"").val(data.empVmodel.PhoneNumber);

            },
            error: function (e) {

                console.log(e);
            },
        });





    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.OzgecmisViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
