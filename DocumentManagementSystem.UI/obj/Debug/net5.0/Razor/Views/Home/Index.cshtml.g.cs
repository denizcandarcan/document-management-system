#pragma checksum "C:\Users\deniz\OneDrive\Belgeler\Projects\.NET\DocumentManagementSystem\DocumentManagementSystem.UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a928fb544ebd14f9ea6cedf64ad190d4ba6d848"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "C:\Users\deniz\OneDrive\Belgeler\Projects\.NET\DocumentManagementSystem\DocumentManagementSystem.UI\Views\_ViewImports.cshtml"
using DocumentManagementSystem.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a928fb544ebd14f9ea6cedf64ad190d4ba6d848", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eeabc5302ee6c9be1fcbdab9e9df7755bb24b1e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DocumentListDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\deniz\OneDrive\Belgeler\Projects\.NET\DocumentManagementSystem\DocumentManagementSystem.UI\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<nav class=""layout-navbar container-xxl navbar navbar-expand-xl navbar-detached align-items-center bg-navbar-theme""
     id=""layout-navbar"">
    <div class=""layout-menu-toggle navbar-nav align-items-xl-center me-3 me-xl-0 d-xl-none"">
        <a class=""nav-item nav-link px-0 me-xl-4"" href=""javascript:void(0)"">
            <i class=""bx bx-menu bx-sm""></i>
        </a>
    </div>

    <div class=""navbar-nav-right d-flex align-items-center"" id=""navbar-collapse"">
        <!-- Search -->
        <div class=""navbar-nav align-items-center"">
            <div class=""nav-item d-flex align-items-center"">
                <i class=""bx bx-search fs-4 lh-0""></i>
                <input type=""text""
                       class=""form-control border-0 shadow-none""
                       placeholder=""Search...""
                       aria-label=""Search..."" />
            </div>
        </div>
        <!-- /Search -->

        <ul class=""navbar-nav flex-row align-items-center ms-auto"">
            <!-- Place ");
            WriteLiteral(@"this tag where you want the button to render. -->
            <!-- User -->
            <li class=""nav-item navbar-dropdown dropdown-user dropdown"">
                <a class=""nav-link dropdown-toggle hide-arrow"" href=""javascript:void(0);"" data-bs-toggle=""dropdown"">
                    <div class=""avatar avatar-online"">
                        <img src=""../assets/img/avatars/1.png"" class=""w-px-40 h-auto rounded-circle"" />
                    </div>
                </a>
                <ul class=""dropdown-menu dropdown-menu-end"">
                    <li>
                        <a class=""dropdown-item"" href=""#"">
                            <div class=""d-flex"">
                                <div class=""flex-shrink-0 me-3"">
                                    <div class=""avatar avatar-online"">
                                        <img src=""../assets/img/avatars/1.png"" class=""w-px-40 h-auto rounded-circle"" />
                                    </div>
                                </div>
  ");
            WriteLiteral(@"                              <div class=""flex-grow-1"">
                                    <span class=""fw-semibold d-block"">John Doe</span>
                                    <small class=""text-muted"">Admin</small>
                                </div>
                            </div>
                        </a>
                    </li>
                    <li>
                        <div class=""dropdown-divider""></div>
                    </li>
                    <li>
                        <a class=""dropdown-item"" href=""#"">
                            <i class=""bx bx-user me-2""></i>
                            <span class=""align-middle"">My Profile</span>
                        </a>
                    </li>
                    <li>
                        <a class=""dropdown-item"" href=""#"">
                            <i class=""bx bx-cog me-2""></i>
                            <span class=""align-middle"">Settings</span>
                        </a>
                    </li>
  ");
            WriteLiteral(@"                  <li>
                        <a class=""dropdown-item"" href=""#"">
                            <span class=""d-flex align-items-center align-middle"">
                                <i class=""flex-shrink-0 bx bx-credit-card me-2""></i>
                                <span class=""flex-grow-1 align-middle"">Billing</span>
                                <span class=""flex-shrink-0 badge badge-center rounded-pill bg-danger w-px-20 h-px-20"">4</span>
                            </span>
                        </a>
                    </li>
                    <li>
                        <div class=""dropdown-divider""></div>
                    </li>
                    <li>
                        <a class=""dropdown-item"" href=""auth-login-basic.html"">
                            <i class=""bx bx-power-off me-2""></i>
                            <span class=""align-middle"">Log Out</span>
                        </a>
                    </li>
                </ul>
            </li>
     ");
            WriteLiteral(@"       <!--/ User -->
        </ul>
    </div>
</nav>


<div class=""container-xxl flex-grow-1 container-p-y"">
    <h4 class=""fw-bold py-3 mb-4""><span class=""text-muted fw-light"">Tables /</span> Basic Tables</h4>

    <!-- Hoverable Table rows -->
    <div class=""card"">
        <div class=""table-responsive text-nowrap"">
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th>Project</th>
                        <th>Client</th>
                        <th>Users</th>
                        <th>Status</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody class=""table-border-bottom-0"">
                    <tr>
                        <td><i class=""fab fa-angular fa-lg text-danger me-3""></i> <strong>Angular Project</strong></td>
                        <td>Albert Cook</td>
                        <td>
                            <ul class=""list-unstyled use");
            WriteLiteral(@"rs-list m-0 avatar-group d-flex align-items-center"">
                                <li data-bs-toggle=""tooltip""
                                    data-popup=""tooltip-custom""
                                    data-bs-placement=""top""
                                    class=""avatar avatar-xs pull-up""
                                    title=""Lilian Fuller"">
                                    <img src=""../assets/img/avatars/5.png"" alt=""Avatar"" class=""rounded-circle"" />
                                </li>
                                <li data-bs-toggle=""tooltip""
                                    data-popup=""tooltip-custom""
                                    data-bs-placement=""top""
                                    class=""avatar avatar-xs pull-up""
                                    title=""Sophia Wilkerson"">
                                    <img src=""../assets/img/avatars/6.png"" alt=""Avatar"" class=""rounded-circle"" />
                                </li>
                       ");
            WriteLiteral(@"         <li data-bs-toggle=""tooltip""
                                    data-popup=""tooltip-custom""
                                    data-bs-placement=""top""
                                    class=""avatar avatar-xs pull-up""
                                    title=""Christina Parker"">
                                    <img src=""../assets/img/avatars/7.png"" alt=""Avatar"" class=""rounded-circle"" />
                                </li>
                            </ul>
                        </td>
                        <td><span class=""badge bg-label-primary me-1"">Active</span></td>
                        <td>
                            <div class=""dropdown"">
                                <button type=""button"" class=""btn p-0 dropdown-toggle hide-arrow"" data-bs-toggle=""dropdown"">
                                    <i class=""bx bx-dots-vertical-rounded""></i>
                                </button>
                                <div class=""dropdown-menu"">
                        ");
            WriteLiteral(@"            <a class=""dropdown-item"" href=""javascript:void(0);""><i class=""bx bx-edit-alt me-1""></i> Edit</a>
                                    <a class=""dropdown-item"" href=""javascript:void(0);""><i class=""bx bx-trash me-1""></i> Delete</a>
                                </div>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td><i class=""fab fa-react fa-lg text-info me-3""></i> <strong>React Project</strong></td>
                        <td>Barry Hunter</td>
                        <td>
                            <ul class=""list-unstyled users-list m-0 avatar-group d-flex align-items-center"">
                                <li data-bs-toggle=""tooltip""
                                    data-popup=""tooltip-custom""
                                    data-bs-placement=""top""
                                    class=""avatar avatar-xs pull-up""
                                    title=""Lilian Fuller"">
 ");
            WriteLiteral(@"                                   <img src=""../assets/img/avatars/5.png"" alt=""Avatar"" class=""rounded-circle"" />
                                </li>
                                <li data-bs-toggle=""tooltip""
                                    data-popup=""tooltip-custom""
                                    data-bs-placement=""top""
                                    class=""avatar avatar-xs pull-up""
                                    title=""Sophia Wilkerson"">
                                    <img src=""../assets/img/avatars/6.png"" alt=""Avatar"" class=""rounded-circle"" />
                                </li>
                                <li data-bs-toggle=""tooltip""
                                    data-popup=""tooltip-custom""
                                    data-bs-placement=""top""
                                    class=""avatar avatar-xs pull-up""
                                    title=""Christina Parker"">
                                    <img src=""../assets/img/avatars/7.png"" ");
            WriteLiteral(@"alt=""Avatar"" class=""rounded-circle"" />
                                </li>
                            </ul>
                        </td>
                        <td><span class=""badge bg-label-success me-1"">Completed</span></td>
                        <td>
                            <div class=""dropdown"">
                                <button type=""button"" class=""btn p-0 dropdown-toggle hide-arrow"" data-bs-toggle=""dropdown"">
                                    <i class=""bx bx-dots-vertical-rounded""></i>
                                </button>
                                <div class=""dropdown-menu"">
                                    <a class=""dropdown-item"" href=""javascript:void(0);""><i class=""bx bx-edit-alt me-1""></i> Edit</a>
                                    <a class=""dropdown-item"" href=""javascript:void(0);""><i class=""bx bx-trash me-1""></i> Delete</a>
                                </div>
                            </div>
                        </td>
                    ");
            WriteLiteral(@"</tr>
                    <tr>
                        <td><i class=""fab fa-vuejs fa-lg text-success me-3""></i> <strong>VueJs Project</strong></td>
                        <td>Trevor Baker</td>
                        <td>
                            <ul class=""list-unstyled users-list m-0 avatar-group d-flex align-items-center"">
                                <li data-bs-toggle=""tooltip""
                                    data-popup=""tooltip-custom""
                                    data-bs-placement=""top""
                                    class=""avatar avatar-xs pull-up""
                                    title=""Lilian Fuller"">
                                    <img src=""../assets/img/avatars/5.png"" alt=""Avatar"" class=""rounded-circle"" />
                                </li>
                                <li data-bs-toggle=""tooltip""
                                    data-popup=""tooltip-custom""
                                    data-bs-placement=""top""
                          ");
            WriteLiteral(@"          class=""avatar avatar-xs pull-up""
                                    title=""Sophia Wilkerson"">
                                    <img src=""../assets/img/avatars/6.png"" alt=""Avatar"" class=""rounded-circle"" />
                                </li>
                                <li data-bs-toggle=""tooltip""
                                    data-popup=""tooltip-custom""
                                    data-bs-placement=""top""
                                    class=""avatar avatar-xs pull-up""
                                    title=""Christina Parker"">
                                    <img src=""../assets/img/avatars/7.png"" alt=""Avatar"" class=""rounded-circle"" />
                                </li>
                            </ul>
                        </td>
                        <td><span class=""badge bg-label-info me-1"">Scheduled</span></td>
                        <td>
                            <div class=""dropdown"">
                                <button type=""butt");
            WriteLiteral(@"on"" class=""btn p-0 dropdown-toggle hide-arrow"" data-bs-toggle=""dropdown"">
                                    <i class=""bx bx-dots-vertical-rounded""></i>
                                </button>
                                <div class=""dropdown-menu"">
                                    <a class=""dropdown-item"" href=""javascript:void(0);""><i class=""bx bx-edit-alt me-1""></i> Edit</a>
                                    <a class=""dropdown-item"" href=""javascript:void(0);""><i class=""bx bx-trash me-1""></i> Delete</a>
                                </div>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <i class=""fab fa-bootstrap fa-lg text-primary me-3""></i> <strong>Bootstrap Project</strong>
                        </td>
                        <td>Jerry Milton</td>
                        <td>
                            <ul class=""list-unstyled users-list m-0 avatar-gro");
            WriteLiteral(@"up d-flex align-items-center"">
                                <li data-bs-toggle=""tooltip""
                                    data-popup=""tooltip-custom""
                                    data-bs-placement=""top""
                                    class=""avatar avatar-xs pull-up""
                                    title=""Lilian Fuller"">
                                    <img src=""../assets/img/avatars/5.png"" alt=""Avatar"" class=""rounded-circle"" />
                                </li>
                                <li data-bs-toggle=""tooltip""
                                    data-popup=""tooltip-custom""
                                    data-bs-placement=""top""
                                    class=""avatar avatar-xs pull-up""
                                    title=""Sophia Wilkerson"">
                                    <img src=""../assets/img/avatars/6.png"" alt=""Avatar"" class=""rounded-circle"" />
                                </li>
                                <li data-bs-t");
            WriteLiteral(@"oggle=""tooltip""
                                    data-popup=""tooltip-custom""
                                    data-bs-placement=""top""
                                    class=""avatar avatar-xs pull-up""
                                    title=""Christina Parker"">
                                    <img src=""../assets/img/avatars/7.png"" alt=""Avatar"" class=""rounded-circle"" />
                                </li>
                            </ul>
                        </td>
                        <td><span class=""badge bg-label-warning me-1"">Pending</span></td>
                        <td>
                            <div class=""dropdown"">
                                <button type=""button"" class=""btn p-0 dropdown-toggle hide-arrow"" data-bs-toggle=""dropdown"">
                                    <i class=""bx bx-dots-vertical-rounded""></i>
                                </button>
                                <div class=""dropdown-menu"">
                                    <a class=");
            WriteLiteral(@"""dropdown-item"" href=""javascript:void(0);""><i class=""bx bx-edit-alt me-1""></i> Edit</a>
                                    <a class=""dropdown-item"" href=""javascript:void(0);""><i class=""bx bx-trash me-1""></i> Delete</a>
                                </div>
                            </div>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    <!--/ Hoverable Table rows -->
    </div>
    <hr class=""my-5"" />
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DocumentListDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
