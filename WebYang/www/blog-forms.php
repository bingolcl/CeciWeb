<?php
  //Buffer larger content areas like the main page content
  ob_start();
?>
        <!-- Start single blog -->
        <div class="col-md-8 col-sm-8 col-xs-12">
          <div class="row">
            <div class="col-md-12 col-sm-12 col-xs-12">
              <!-- single-blog start -->
              <article class="blog-post-wrapper">
                <div class="post-information">
                  <h2>常用表格下载</h2>
                  <div class="entry-meta">
                    <span class="author-meta"><i class="fa fa-user"></i>Anna Yang</span>
                    <span><i class="fa fa-clock-o"></i> march 13, 2019</span>
                  </div>
                  <div class="entry-content" >
                      <ul class="list-group">
                          <li class="list-group-item">
                              委托代理人表 -Use of representative form
                            <a href="blog-use-of-representative.html"><i class="fa fa-eye"></i> 浏览</a> |                         
                            <a href="files/imm5476e.pdf" download><i class="fa fa-save"></i> 下载</a>
                          </li>
                          <li class="list-group-item">
                              未成年人监护人表 - Custodian form
                              <a href="blog-custodian.html"><i class="fa fa-eye"></i> 浏览</a> |                         
                              <a href="files/custodian-parent.pdf" download><i class="fa fa-save"></i> 下载</a>
                         </ul>
                  </div>
                </div>
              </article>
              <div class="clear"></div>
              <!-- single-blog end -->
            </div>
          </div>
        </div>
<?php
  //Assign all Page Specific variables
  $pageblogcontent = ob_get_contents();
  ob_end_clean();
  $pagetitle = "常用表格";
  //Apply the template
  include("blog-master-short.php");
?>