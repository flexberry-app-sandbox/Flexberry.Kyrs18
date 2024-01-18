docker build --no-cache -f SQL\Dockerfile.PostgreSql -t kyrs18/postgre-sql ../SQL

docker build --no-cache -f Dockerfile -t kyrs18/app ../..
