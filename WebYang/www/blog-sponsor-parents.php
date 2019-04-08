<?php
  //Buffer larger content areas like the main page content
  ob_start();
?>
        <div class="col-md-8 col-sm-8 col-xs-12">
          <div class="row">
            <div class="col-md-12 col-sm-12 col-xs-12">
              <!-- single-blog start -->
              <article class="blog-post-wrapper">
                <div class="post-information">
                  <h3>加拿大移民丨父母团聚移民 Parents Sponsorship</h3>
                  <div class="entry-meta">
                    <span class="author-meta"><i class="fa fa-user"></i>Anna Yang</span>
                    <span><i class="fa fa-clock-o"></i> march 13, 2019</span>
                  </div>
                  <div class="entry-content">
                      <p>加拿大联邦移民局部长胡森（Ahmed Hussen）于今年8月宣布，从2019年1月起，加拿大父母/祖父母团聚的申请，将会以“先到先得”的方式取代之前随机抽签邀请的方式。</p>
                      <h5><b>背景因素：</b></h5>
                        <p>首先，担保人必须是加拿大公民或永久居民。对于持有临时签证的人士，目前是不可以担保父母/祖父母团聚移民。同时，担保人年龄必须在18岁以上。如果该加拿大公民是孩童，也无法担保其父母/祖父母。</p>
                        <p>其次，担保人需能准确的计算家庭人口数量，并以此推算出担保的最低收入要求。因为申请父母/祖父母团聚移民是需要看家庭总人数（通常包括担保人、配偶、未成年子女、团聚申请中申请人及配偶的父母/祖父母以及其他正在担保或尚在抚养期内的亲属），然后计算家庭收入水平，因此申请者需要在递交之前，仔细的核算家庭的总人数</p>
                     <blockquote>
                      <img src="img/blog/table1.png"/>
                    </blockquote>
                      <h5><b>政府费用：</b></h5>
                       <p>加拿大政府收取：担保人75加元，被担保人475加元，被担保人的配偶550加元，19岁以下小孩150加元，移民申请被批准后还要收取登录费。</p>
                        <p>父母和祖父母可能有资格移民并成为加拿大的永久居民。</p>                    
                        <p>必须要有相关的家庭主要成员已经移民加拿大，并成为资助者。资助者和想要移民的人都必须满足特定的要求。</p>
                        <p>永久居民的申请人必须通过体检，犯罪记录和背景的调查。有犯罪记录的人可能不会被获准入境加拿大。对加拿大治安可能构成危险的人也不会被获准进入。申请人需要提供本国警察当局开的证明。在申请的应用套件中阐述身体状况，犯罪记录和背景。</p>
                         <p>资助父母或祖父母</p>
                         <p>如果你是年满18周岁和以上的公民或永久居民，你可以资助你的父母或祖父母。</p>

                    <h5><b>作为资助人：</b></h5>
                        <p>你和被资助人必须签署资助协议，保证你在必要时会对被资助人进行经济支持。这项协议还申明要成为永久居民必须不遗余力的支持自己。22岁以下的人没有必要必须签署这份协议。魁省的居民必须和省政府签署担保——约束资助的合同。</p>                    
                        <p>根据其年龄和资助人关系，还必须承诺对资助人和有资格对他们进行三年到十年陪护人员的经济支持。这个时间从他们成为永久居民算起。</p>
                        <p>如果你居住在魁省，加拿大移民局准许你成为资助人后，你还要达到魁省对移民和资助的相关要求。</p>
                        <p>想要资助你的父母或祖父母，你必须现居加拿大。</p>
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
  $pagetitle = "父母团聚移民";
  //Apply the template
  include("blog-master.php");
?>