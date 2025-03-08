openssl req -x509 -newkey rsa:4096 -keyout /etc/ssl/private/key.pem -out /etc/ssl/certs/cert.pem -days 365 -nodes \
    -subj "/C=US/ST=State/L=City/O=Company/OU=Org/CN=localhost"

# Start Nginx
nginx -g "daemon off;"