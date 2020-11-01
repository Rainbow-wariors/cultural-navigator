# -*- coding: utf-8 -*-
#from django.http import HttpResponse

#def hello(request):
#    return HttpResponse("Здравствуй, Мир")

#from django.http import HttpResponse
# import datetime

#def current_datetime(request):
#    now = datetime.datetime.now()
#    html = "<html><body>It is now %s.</body></html>" % now
#    return HttpResponse(html)

'''

from django.contrib import auth
from django.http import HttpResponse

def login(request):
    username = request.POST['username']
    password = request.POST['password']
    user = auth.authenticate(username=username, password=password)
    if user is not None and user.is_active:
        # Правильный пароль и пользователь "активен"
        auth.login(request, user)
        # Перенаправление на "правильную" страницу
        return HttpResponseRedirect("/account/loggedin/")
    else:
        # Отображение страницы с ошибкой
        return HttpResponseRedirect("/account/invalid/")

def logout(request):
    auth.logout(request)
    # Перенаправление на страницу.
    return HttpResponseRedirect("/account/loggedout/")

'''

# Create your views here.


#from django.http import HttpResponse
#
#
#def index(request):
#    return HttpResponse("Hello, World!")

#from django.shortcuts import render
#from django.contrib.auth.views import (
#    LoginView, LogoutView
#)
#from users.models import User

#class login_view(LoginView):
    # The line below overrides the default template path of <appname>/<modelname>_login.html
#    template_name1 = 'login.html' # Where accounts/login.html is the path under the templates folder as defined in your settings.py file
#class logout_view(LogoutView):
    # The line below overrides the default template path of <appname>/<modelname>_login.html
#    template_name2 = 'logout.html' # Where accounts/login.html is the path under the templates folder as defined in your settings.py file   


from django.http import HttpResponse
from django.shortcuts import render
from django.contrib.auth import authenticate, login
from .forms import LoginForm
import psycopg2
from django.http import JsonResponse

import sys
sys.path.append('/root/megaproject/accounts/utils')

from recommendation import recommend


def user_login(request):
    if request.method == 'GET':
        form = LoginForm(request.GET)
        if form.is_valid():
            cd = form.cleaned_data
            user = authenticate(username=cd['username'], password=cd['password'])
            if user is not None:
                if user.is_active:
                    login(request, user)
                    return HttpResponse('Authenticated successfully')
                else:
                    return HttpResponse('Disabled account')
            else:
                return HttpResponse('Invalid login')
    else:
        form = LoginForm()
    return render(request, 'account/login.html', {'form': form})

def index(request):
    if request.method == 'GET':
        name = request.GET['name']
        k = request.GET['k']

        return HttpResponse(JsonResponse(recommend(name, int(k))))