
<?php
  //Buffer larger content areas like the main page content
  ob_start();
?>
        <div class="blog-page area-padding">
    <div class="container">
      <div class="row">
        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12">
          <div class="page-head-blog">
            <div class="single-blog-page">
              <div class="left-blog">
                <h4>categories</h4>
                <ul>
                  <li>
                    <a href="blog-details.html">BCPNP BC 省提名移民</a>
                  </li>
                  <li>
                    <a href="blog-details.html">Express Entry 快速通道移民</a>
                  </li>
                  <li>
                    <a href="blog-sponsorship.php">家庭团聚</a>
                  </li>
                  <li>
                    <a href="blog-forms.php">常用表格下载</a>
                  </li>
                  <li>
                    <a href="blog-BUSP.php">2019夏令营</a>
                  </li>
                </ul>
              </div>
            </div>
            <div class="single-blog-page">
              <!-- recent start -->
              <div class="left-blog">
                <h4>recent post</h4>
                <div class="recent-post">
                  <!-- start single post -->
                  <div class="recent-single-post">
                    <div class="post-img">
                      <a href="blog-details.html">
						<img src="img/blog/1.jpg" alt="">
				      </a>
                    </div>
                    <div class="pst-content">
                      <p><a href="blog-details.html"> Redug Lerse dolor sit amet consect adipis elit.</a></p>
                    </div>
                  </div>
                  <!-- End single post -->
                  <!-- start single post -->
                  <div class="recent-single-post">
                    <div class="post-img">
                      <a href="blog-details.html">
												   <img src="img/blog/2.jpg" alt="">
												</a>
                    </div>
                    <div class="pst-content">
                      <p><a href="blog-details.html"> Redug Lerse dolor sit amet consect adipis elit.</a></p>
                    </div>
                  </div>
                  <!-- End single post -->
                  <!-- start single post -->
                  <div class="recent-single-post">
                    <div class="post-img">
                      <a href="blog-details.html">
												   <img src="img/blog/3.jpg" alt="">
												</a>
                    </div>
                    <div class="pst-content">
                      <p><a href="blog-details.html"> Redug Lerse dolor sit amet consect adipis elit.</a></p>
                    </div>
                  </div>
                  <!-- End single post -->
                  <!-- start single post -->
                  <div class="recent-single-post">
                    <div class="post-img">
                      <a href="blog-details.html">
												   <img src="img/blog/4.jpg" alt="">
												</a>
                    </div>
                    <div class="pst-content">
                      <p><a href="blog-details.html"> Redug Lerse dolor sit amet consect adipis elit.</a></p>
                    </div>
                  </div>
                  <!-- End single post -->
                </div>
              </div>
              <!-- recent end -->
            </div>
          </div>
        </div>
        <!-- End left sidebar -->
        <!-- Start single blog -->
        <?php
        echo $pageblogcontent; 
        ?>
      </div>
    </div>
  </div>
  <!-- End Blog Area -->
  <div class="clearfix"></div>
<?php
  //Assign all Page Specific variables
  $pagemaincontent = ob_get_contents();
  ob_end_clean();
  //Apply the template
  include("master.php");
?>
