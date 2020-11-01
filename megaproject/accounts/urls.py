#from django.contrib.auth import views
#from django.urls import path

#urlpatterns = [
#    path('login/', views.LoginView.as_view(), name='login'),
#    path('logout/', views.LogoutView.as_view(), name='logout'),

#]

from django.conf.urls import url
from . import views
from django.urls import path

urlpatterns = [
    # post views
    #url(r'^login/$', views.user_login, name='login'),
    path('', views.index, name='index')
    #url(r'^login/$', 'django.contrib.auth.views.login', name='login'),
    #url(r'^logout/$', 'django.contrib.auth.views.logout', name='logout'),
    #url(r'^logout-then-login/$', 'django.contrib.auth.views.logout_then_login', name='logout_then_login'),
]