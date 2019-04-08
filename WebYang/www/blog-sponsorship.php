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
                  <h2>加拿大| 家庭团聚移民</h2>
                  <div class="entry-meta">
                    <span class="author-meta"><i class="fa fa-user"></i>Anna Yang</span>
                    <span><i class="fa fa-clock-o"></i> march 13, 2019</span>
                  </div>
                  <div class="entry-content" >
                      <ul class="list-group">
                          <li class="list-group-item">                              
                            <a href="blog-sponsor-parents.html">担保父母、祖父母 -Sponsor parents & Grand parents</a>
                          </li>
                          <li class="list-group-item">
                              <a href="blog-custodian.html">担保配偶及子女 Sponsor spouse and children </a>
                          </li>
                          <li class="list-group-item">
                              <a href="blog-custodian.html">担保其他亲属 	Other family member & relatives </a>
                          </li>
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
  $pagetitle = "家庭团聚移民";
  //Apply the template
  include("blog-master-short.php");
?>