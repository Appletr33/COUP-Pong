from flask import Flask, render_template, request, make_response

web_site = Flask(__name__)


@web_site.route('/')
def index():
  r = make_response(render_template('index.html'))
  #r.headers.set('Content-Encoding', "br")
  return r


web_site.run(host='0.0.0.0', port=8080)