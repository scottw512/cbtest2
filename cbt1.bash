docker-compose -f cbtest/docker-compose.yml up --exit-code-from build_container build_container
echo $?

