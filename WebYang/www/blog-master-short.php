
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
